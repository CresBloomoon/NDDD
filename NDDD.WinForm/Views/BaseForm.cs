using NDDD.Domain;
using NDDD.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDDD.WinForm.Views
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            toolStripStatusLabel1.Visible = false;
#if DEBUG
            toolStripStatusLabel1.Visible = true;
#endif

            UserIdLabel.Text = Shared.LoginId;

        }

        protected void ExceptionProc(Exception ex)
        {
            MessageBoxIcon icon = MessageBoxIcon.Error;
            string caption = "エラー";
            var exceptionBase = ex as ExceptionBase;
            if (null != exceptionBase)
            {
                if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Info)
                {
                    icon = MessageBoxIcon.Information;
                    caption = "情報";
                }
                else if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Warning)
                {
                    icon = MessageBoxIcon.Warning;
                    caption = "警告";
                }
            }

            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, icon);

        }
    }
}
