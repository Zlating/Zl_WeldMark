using System;

namespace Zl_WeldMark
{
    public partial class MainForm : Tekla.Structures.Dialog.PluginFormBase
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OkApplyModifyGetOnOffCancel_OkClicked(object sender, EventArgs e)
        {
            this.Apply();
            this.Close();
        }

        private void OkApplyModifyGetOnOffCancel_ApplyClicked(object sender, EventArgs e)
        {
            this.Apply();
        }

        private void OkApplyModifyGetOnOffCancel_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkApplyModifyGetOnOffCancel_GetClicked(object sender, EventArgs e)
        {
            this.Get();
        }

        private void OkApplyModifyGetOnOffCancel_ModifyClicked(object sender, EventArgs e)
        {
            this.Modify();
        }

        private void OkApplyModifyGetOnOffCancel_OnOffClicked(object sender, EventArgs e)
        {
            this.ToggleSelection();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            toShop(0);
        }


        void toShop(object text)
        {
            SetAttributeValue(textBox3, text);
            textBox3.Text = text.ToString();
        }

        void toType(string text)
        {
            SetAttributeValue(textBox1, text);
            textBox1.Text = text;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            toShop(1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            toType(radioButton1.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            toType(radioButton2.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            toType(radioButton3.Text);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            toType(radioButton4.Text);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            toType(radioButton5.Text);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            toType(radioButton6.Text);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            toType(radioButton7.Text);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            toType(radioButton8.Text);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            toType(radioButton9.Text);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            toType(radioButton10.Text);
        }
    }
}
