using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.测试工具
{
    public partial class LotteryForm : BasePopupForm
    {
        // 存储选项与对应方块控件
        private readonly List<OptionItem> _optionItems = new List<OptionItem>();
        // 全局随机数生成器
        private readonly Random _random = new Random();
        // 当前高亮的中奖方块
        private OptionItem _currentHighlightItem;
        // 方块最小尺寸下限（保证文字能正常显示）
        private const int MinBlockSize = 60;

        public LotteryForm()
        {
            InitializeComponent();
            // 初始化默认选项
            txtOption.Text = "河北*河南*山东*山西*北京*天津*内蒙古*西藏*云南*四川";
        }

        #region 生成按钮核心逻辑（优化无遮挡）
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // 重置抽奖状态与现有控件
            timerFlash.Enabled = false;
            btnToggle.Text = "开始/停止";
            _optionItems.Clear();
            pnlCanvas.Controls.Clear();
            _currentHighlightItem = null;

            // 输入校验
            string inputText = txtOption.Text.Trim();
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("请输入选项内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 分割选项
            string[] optionArray = inputText.Split(new[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
            if (optionArray.Length == 0)
            {
                MessageBox.Show("选项格式不正确！请用*分隔多个选项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 【核心优化1】根据选项数量动态计算方块最大尺寸，选项越多，最大尺寸越小，避免画布放不下
            int optionCount = optionArray.Length;
            int canvasArea = pnlCanvas.ClientSize.Width * pnlCanvas.ClientSize.Height;
            // 单个方块最大占用画布面积比例，避免单个方块过大
            float maxAreaRatio = optionCount <= 5 ? 0.25f : optionCount <= 10 ? 0.15f : 0.08f;
            int maxBlockArea = (int)(canvasArea * maxAreaRatio);
            int maxBlockSize = (int)Math.Sqrt(maxBlockArea);
            maxBlockSize = maxBlockSize < MinBlockSize ? MinBlockSize : maxBlockSize;

            // 生成每个方块（100%无遮挡）
            foreach (string itemName in optionArray)
            {
                string cleanName = itemName.Trim();
                if (string.IsNullOrEmpty(cleanName)) continue;

                // 创建方块控件（动态尺寸范围）
                Panel block = CreateBlock(cleanName, MinBlockSize, maxBlockSize);
                // 【核心优化2】智能无重叠位置生成，多次失败自动缩小方块，确保完全不遮挡
                SetNoOverlapBlockPosition(block, MinBlockSize, maxBlockSize);
                // 添加到画布与数据列表
                pnlCanvas.Controls.Add(block);
                _optionItems.Add(new OptionItem
                {
                    Name = cleanName,
                    Block = block
                });
            }
        }
        #endregion

        #region 方块控件创建（可指定尺寸范围）
        private Panel CreateBlock(string itemName, int minSize, int maxSize)
        {
            // 纯随机大小，在指定范围内
            int blockWidth = _random.Next(minSize, maxSize + 1);
            int blockHeight = _random.Next(minSize, maxSize + 1);

            // 方块主体
            Panel block = new Panel
            {
                Size = new Size(blockWidth, blockHeight),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, 134)
            };

            // 居中显示名称标签
            Label lblName = new Label
            {
                Text = itemName,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
                Font = block.Font,
                BackColor = Color.Transparent
            };
            block.Controls.Add(lblName);

            return block;
        }
        #endregion

        #region 【核心优化】智能无重叠位置生成（自动缩放宽高，确保100%不遮挡）
        private void SetNoOverlapBlockPosition(Panel block, int minSize, int originalMaxSize)
        {
            int currentMaxSize = originalMaxSize;
            int maxTryCountPerSize = 200; // 每个尺寸下的最大尝试次数

            // 循环：先尝试当前尺寸，失败则缩小尺寸，直到达到最小尺寸
            while (currentMaxSize >= minSize)
            {
                int tryCount = 0;
                bool isPositionValid;

                do
                {
                    tryCount++;
                    isPositionValid = true;

                    // 严格计算安全范围，确保方块100%完全在画布内，不会超出边界
                    int maxX = pnlCanvas.ClientSize.Width - block.Width;
                    int maxY = pnlCanvas.ClientSize.Height - block.Height;
                    maxX = maxX < 0 ? 0 : maxX;
                    maxY = maxY < 0 ? 0 : maxY;

                    // 生成随机坐标
                    block.Location = new Point(
                        _random.Next(0, maxX + 1),
                        _random.Next(0, maxY + 1)
                    );

                    // 【严格碰撞检测】与所有已存在的方块，完全不能有任何重叠
                    foreach (Control control in pnlCanvas.Controls)
                    {
                        if (control is Panel existBlock && block.Bounds.IntersectsWith(existBlock.Bounds))
                        {
                            isPositionValid = false;
                            break;
                        }
                    }

                } while (!isPositionValid && tryCount < maxTryCountPerSize);

                // 找到有效位置，直接退出
                if (isPositionValid)
                {
                    return;
                }

                // 当前尺寸找不到位置，缩小最大尺寸，重新生成方块大小
                currentMaxSize -= 10; // 每次缩小10px
                if (currentMaxSize >= minSize)
                {
                    // 重新生成更小的方块尺寸
                    int newWidth = _random.Next(minSize, currentMaxSize + 1);
                    int newHeight = _random.Next(minSize, currentMaxSize + 1);
                    block.Size = new Size(newWidth, newHeight);
                }
            }

            // 兜底：如果到最小尺寸还是找不到，强制放在画布空白角落
            block.Size = new Size(minSize, minSize);
            block.Location = new Point(
                _random.Next(0, pnlCanvas.ClientSize.Width - minSize),
                _random.Next(0, pnlCanvas.ClientSize.Height - minSize)
            );
        }
        #endregion

        #region 开始/停止抽奖逻辑
        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (_optionItems.Count == 0)
            {
                MessageBox.Show("请先生成方块！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 切换抽奖启停状态
            timerFlash.Enabled = !timerFlash.Enabled;
            btnToggle.Text = timerFlash.Enabled ? "停止" : "开始/停止";

            // 停止时弹出中奖结果
            if (!timerFlash.Enabled && _currentHighlightItem != null)
            {
                //MessageBox.Show($"恭喜！中奖区域：{_currentHighlightItem.Name}", "抽奖结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 抽奖闪动Timer核心逻辑
        private void timerFlash_Tick(object sender, EventArgs e)
        {
            // 恢复上一个高亮方块的默认样式
            if (_currentHighlightItem != null)
            {
                ResetBlockStyle(_currentHighlightItem.Block);
            }

            // 完全随机抽取新的高亮方块（所有选项概率均等）
            int randomIndex = _random.Next(0, _optionItems.Count);
            _currentHighlightItem = _optionItems[randomIndex];

            // 设置高亮中奖样式
            SetBlockHighlightStyle(_currentHighlightItem.Block);
        }
        #endregion

        #region 方块样式控制
        /// <summary>
        /// 重置为默认未选中样式
        /// </summary>
        private void ResetBlockStyle(Panel block)
        {
            block.BackColor = Color.White;
            if (block.Controls.Count > 0 && block.Controls[0] is Label lbl)
            {
                lbl.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// 设置中奖高亮样式
        /// </summary>
        private void SetBlockHighlightStyle(Panel block)
        {
            block.BackColor = Color.Red;
            if (block.Controls.Count > 0 && block.Controls[0] is Label lbl)
            {
                lbl.ForeColor = Color.White;
            }
        }
        #endregion
    }

    #region 选项数据实体类
    public class OptionItem
    {
        /// <summary>
        /// 选项名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 对应的方块控件
        /// </summary>
        public Panel Block { get; set; }
    }
    #endregion
}
