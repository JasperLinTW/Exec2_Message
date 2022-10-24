namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.greetButton = new System.Windows.Forms.Button();
			this.greetLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// greetButton
			// 
			this.greetButton.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.greetButton.Location = new System.Drawing.Point(120, 46);
			this.greetButton.Name = "greetButton";
			this.greetButton.Size = new System.Drawing.Size(186, 34);
			this.greetButton.TabIndex = 0;
			this.greetButton.Text = "點我報時";
			this.greetButton.UseVisualStyleBackColor = true;
			this.greetButton.Click += new System.EventHandler(this.greetButton_Click);
			// 
			// greetLabel
			// 
			this.greetLabel.AutoSize = true;
			this.greetLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.greetLabel.Location = new System.Drawing.Point(12, 100);
			this.greetLabel.Name = "greetLabel";
			this.greetLabel.Size = new System.Drawing.Size(86, 20);
			this.greetLabel.TabIndex = 1;
			this.greetLabel.Text = "greetLable";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 207);
			this.Controls.Add(this.greetLabel);
			this.Controls.Add(this.greetButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button greetButton;
		private System.Windows.Forms.Label greetLabel;
	}
}

