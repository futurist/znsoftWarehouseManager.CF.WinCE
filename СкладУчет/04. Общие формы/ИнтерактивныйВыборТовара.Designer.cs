﻿namespace СкладскойУчет
{
    partial class ИнтерактивныйВыборТовара
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс  следует удалить; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.СписокВыбора = new System.Windows.Forms.ListView();
            this.Назад = new System.Windows.Forms.Button();
            this.Далее = new System.Windows.Forms.Button();
            this.Инструкция = new System.Windows.Forms.Label();
            this.НаименованиеТовара = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // СписокВыбора
            // 
            this.СписокВыбора.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.СписокВыбора.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.СписокВыбора.FullRowSelect = true;
            this.СписокВыбора.Location = new System.Drawing.Point(3, 17);
            this.СписокВыбора.Name = "СписокВыбора";
            this.СписокВыбора.Size = new System.Drawing.Size(234, 154);
            this.СписокВыбора.TabIndex = 0;
            this.СписокВыбора.Tag = "Таблица";
            this.СписокВыбора.View = System.Windows.Forms.View.Details;
            this.СписокВыбора.ItemActivate += new System.EventHandler(this.СписокВыбора_ItemActivate);
            this.СписокВыбора.SelectedIndexChanged += new System.EventHandler(this.СписокВыбора_SelectedIndexChanged);
            // 
            // Назад
            // 
            this.Назад.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Назад.Location = new System.Drawing.Point(2, 294);
            this.Назад.Name = "Назад";
            this.Назад.Size = new System.Drawing.Size(105, 22);
            this.Назад.TabIndex = 1;
            this.Назад.Text = "&0. Назад";
            this.Назад.Click += new System.EventHandler(this.ПриНажатииНаКнопку);
            // 
            // Далее
            // 
            this.Далее.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Далее.Location = new System.Drawing.Point(133, 294);
            this.Далее.Name = "Далее";
            this.Далее.Size = new System.Drawing.Size(105, 22);
            this.Далее.TabIndex = 2;
            this.Далее.Text = "&1. Далее";
            this.Далее.Click += new System.EventHandler(this.ПриНажатииНаКнопку);
            // 
            // Инструкция
            // 
            this.Инструкция.Location = new System.Drawing.Point(3, 0);
            this.Инструкция.Name = "Инструкция";
            this.Инструкция.Size = new System.Drawing.Size(230, 15);
            this.Инструкция.Tag = "Инструкция";
            this.Инструкция.Text = "Выберите товар из списка";
            // 
            // НаименованиеТовара
            // 
            this.НаименованиеТовара.Location = new System.Drawing.Point(3, 173);
            this.НаименованиеТовара.Name = "НаименованиеТовара";
            this.НаименованиеТовара.Size = new System.Drawing.Size(234, 100);
            this.НаименованиеТовара.Text = "Товар";
            // 
            // ИнтерактивныйВыборТовара
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.НаименованиеТовара);
            this.Controls.Add(this.Инструкция);
            this.Controls.Add(this.Далее);
            this.Controls.Add(this.Назад);
            this.Controls.Add(this.СписокВыбора);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "ИнтерактивныйВыборТовара";
            this.Text = "Выбор";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ИнтерактивныйВыборТовара_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ИнтерактивныйВыборТовара_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView СписокВыбора;
        private System.Windows.Forms.Button Назад;
        private System.Windows.Forms.Button Далее;
        public System.Windows.Forms.Label Инструкция;
        private System.Windows.Forms.Label НаименованиеТовара;
    }
}