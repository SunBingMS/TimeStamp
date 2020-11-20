using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace TimeStamp
{
    public partial class TimeStamp : Form
    {
        public TimeStamp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Target Path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTarget_Click(object sender, EventArgs e)
        {
            try
            {
                //ダイアログを表示する
                if (fbdTarget.ShowDialog(this) == DialogResult.OK)
                {
                    //選択されたフォルダを表示する
                    txtTarget.Text = fbdTarget.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                new StackFrame(0).GetMethod().Name,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        /// <summary>
        /// Original Path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOriginal_Click(object sender, EventArgs e)
        {
            try
            {
                //ダイアログを表示する
                if (fbdOriginal.ShowDialog(this) == DialogResult.OK)
                {
                    //選択されたフォルダを表示する
                    txtOriginal.Text = fbdOriginal.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                new StackFrame(0).GetMethod().Name,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        /// <summary>
        /// Time Stamp Change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //Targetチェック
                if (txtTarget.Text.Equals(""))
                {
                    MessageBox.Show("変更ターゲットのフォルダを設定してください。",
                                    new StackFrame(0).GetMethod().Name,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                //Originalチェック
                if (txtOriginal.Text.Equals(""))
                {
                    MessageBox.Show("参照元のフォルダを設定してください。",
                                    new StackFrame(0).GetMethod().Name,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                //Targetの全部ファイル取得
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(txtTarget.Text);
                IEnumerable<System.IO.FileInfo> files =
                    di.EnumerateFiles("*", System.IO.SearchOption.AllDirectories);

                //Targetファイルを列挙する
                foreach (System.IO.FileInfo fileTarget in files)
                {
                    //Originalフォルダの同じファイル
                    string strOriginalFile = fileTarget.FullName.Replace(txtTarget.Text, txtOriginal.Text);

                    //同じファイル存在の場合
                    if (System.IO.File.Exists(strOriginalFile))
                    {
                        System.IO.FileInfo fileOriginal = new System.IO.FileInfo(strOriginalFile);

                        //ファイルサイズ同じの場合
                        if (fileOriginal.Length == fileTarget.Length)
                        {
                            tsslFile.Text = fileTarget.FullName;
                            Application.DoEvents();

                            fileTarget.LastWriteTime = fileOriginal.LastWriteTime;
                            fileTarget.CreationTime = fileOriginal.CreationTime;
                            fileTarget.LastAccessTime = fileOriginal.LastAccessTime;
                        }
                    }
                }

                MessageBox.Show("更新完了",
                                "お知らせ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                new StackFrame(0).GetMethod().Name,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

    }
}
