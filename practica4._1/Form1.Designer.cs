namespace practica4._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addButton = new Button();
            removeButton = new Button();
            listBoxNumbers = new ListBox();
            textBoxNumber = new TextBox();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(203, 214);
            addButton.Name = "addButton";
            addButton.Size = new Size(84, 29);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(447, 228);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(84, 29);
            removeButton.TabIndex = 1;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // listBoxNumbers
            // 
            listBoxNumbers.FormattingEnabled = true;
            listBoxNumbers.Location = new Point(427, 107);
            listBoxNumbers.Name = "listBoxNumbers";
            listBoxNumbers.Size = new Size(134, 104);
            listBoxNumbers.TabIndex = 2;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(175, 141);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(112, 27);
            textBoxNumber.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(textBoxNumber);
            Controls.Add(listBoxNumbers);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox listBoxNumbers;
        private System.Windows.Forms.TextBox textBoxNumber;
    }
}
