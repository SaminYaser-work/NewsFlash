using System.Collections.Generic;
using System.Windows.Forms;

namespace News_reader_mk_2
{
    struct SidePanelTreeView
    {
        private List<string> world;
        private List<TreeNode> sports;
        private List<TreeNode> lifestyle;
        private List<TreeNode> business;
        private List<TreeNode> health;

        public List<string> World { get => world; set => world = value; }
        public List<TreeNode> Sports { get => sports; set => sports = value; }
        public List<TreeNode> Lifestyle { get => lifestyle; set => lifestyle = value; }
        public List<TreeNode> Business { get => business; set => business = value; }
        public List<TreeNode> Health { get => health; set => health = value; }
    }
}
