namespace Hunting_List_for_MH3U
{
    partial class MainForm
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
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbWpnFilters = new System.Windows.Forms.GroupBox();
            this.chkWpnBow = new System.Windows.Forms.CheckBox();
            this.chkWpnHeavyBowgun = new System.Windows.Forms.CheckBox();
            this.chkWpnLightBowgun = new System.Windows.Forms.CheckBox();
            this.chkWpnSwitchAxe = new System.Windows.Forms.CheckBox();
            this.chkWpnGunlance = new System.Windows.Forms.CheckBox();
            this.chkWpnLance = new System.Windows.Forms.CheckBox();
            this.chkWpnHuntingHorn = new System.Windows.Forms.CheckBox();
            this.chkWpnHammer = new System.Windows.Forms.CheckBox();
            this.chkWpnDualBlades = new System.Windows.Forms.CheckBox();
            this.chkWpnSwordAndShield = new System.Windows.Forms.CheckBox();
            this.chkWpnLongSword = new System.Windows.Forms.CheckBox();
            this.chkWpnGreatSword = new System.Windows.Forms.CheckBox();
            this.gbAmrFilters = new System.Windows.Forms.GroupBox();
            this.chkLegs = new System.Windows.Forms.CheckBox();
            this.chkAmrWaist = new System.Windows.Forms.CheckBox();
            this.chkAmrArms = new System.Windows.Forms.CheckBox();
            this.chkAmrChest = new System.Windows.Forms.CheckBox();
            this.chkAmrHead = new System.Windows.Forms.CheckBox();
            this.btnAmrGender = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbFilters.SuspendLayout();
            this.gbWpnFilters.SuspendLayout();
            this.gbAmrFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.lblSearch);
            this.gbFilters.Controls.Add(this.txtSearch);
            this.gbFilters.Controls.Add(this.gbWpnFilters);
            this.gbFilters.Controls.Add(this.gbAmrFilters);
            this.gbFilters.Location = new System.Drawing.Point(12, 12);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(464, 122);
            this.gbFilters.TabIndex = 0;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 86);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(59, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // gbWpnFilters
            // 
            this.gbWpnFilters.Controls.Add(this.chkWpnBow);
            this.gbWpnFilters.Controls.Add(this.chkWpnHeavyBowgun);
            this.gbWpnFilters.Controls.Add(this.chkWpnLightBowgun);
            this.gbWpnFilters.Controls.Add(this.chkWpnSwitchAxe);
            this.gbWpnFilters.Controls.Add(this.chkWpnGunlance);
            this.gbWpnFilters.Controls.Add(this.chkWpnLance);
            this.gbWpnFilters.Controls.Add(this.chkWpnHuntingHorn);
            this.gbWpnFilters.Controls.Add(this.chkWpnHammer);
            this.gbWpnFilters.Controls.Add(this.chkWpnDualBlades);
            this.gbWpnFilters.Controls.Add(this.chkWpnSwordAndShield);
            this.gbWpnFilters.Controls.Add(this.chkWpnLongSword);
            this.gbWpnFilters.Controls.Add(this.chkWpnGreatSword);
            this.gbWpnFilters.Location = new System.Drawing.Point(235, 19);
            this.gbWpnFilters.Name = "gbWpnFilters";
            this.gbWpnFilters.Size = new System.Drawing.Size(223, 95);
            this.gbWpnFilters.TabIndex = 1;
            this.gbWpnFilters.TabStop = false;
            this.gbWpnFilters.Text = "Weapons";
            // 
            // chkWpnBow
            // 
            this.chkWpnBow.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnBow.Checked = true;
            this.chkWpnBow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnBow.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnBowSmall;
            this.chkWpnBow.Location = new System.Drawing.Point(187, 56);
            this.chkWpnBow.Name = "chkWpnBow";
            this.chkWpnBow.Size = new System.Drawing.Size(30, 30);
            this.chkWpnBow.TabIndex = 11;
            this.chkWpnBow.UseVisualStyleBackColor = true;
            // 
            // chkWpnHeavyBowgun
            // 
            this.chkWpnHeavyBowgun.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnHeavyBowgun.Checked = true;
            this.chkWpnHeavyBowgun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnHeavyBowgun.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnHeavyBowgunSmall;
            this.chkWpnHeavyBowgun.Location = new System.Drawing.Point(151, 56);
            this.chkWpnHeavyBowgun.Name = "chkWpnHeavyBowgun";
            this.chkWpnHeavyBowgun.Size = new System.Drawing.Size(30, 30);
            this.chkWpnHeavyBowgun.TabIndex = 10;
            this.chkWpnHeavyBowgun.UseVisualStyleBackColor = true;
            // 
            // chkWpnLightBowgun
            // 
            this.chkWpnLightBowgun.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnLightBowgun.Checked = true;
            this.chkWpnLightBowgun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnLightBowgun.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnLightBowgunSmall;
            this.chkWpnLightBowgun.Location = new System.Drawing.Point(115, 56);
            this.chkWpnLightBowgun.Name = "chkWpnLightBowgun";
            this.chkWpnLightBowgun.Size = new System.Drawing.Size(30, 30);
            this.chkWpnLightBowgun.TabIndex = 9;
            this.chkWpnLightBowgun.UseVisualStyleBackColor = true;
            // 
            // chkWpnSwitchAxe
            // 
            this.chkWpnSwitchAxe.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnSwitchAxe.Checked = true;
            this.chkWpnSwitchAxe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnSwitchAxe.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnSwitchAxeSmall;
            this.chkWpnSwitchAxe.Location = new System.Drawing.Point(79, 56);
            this.chkWpnSwitchAxe.Name = "chkWpnSwitchAxe";
            this.chkWpnSwitchAxe.Size = new System.Drawing.Size(30, 30);
            this.chkWpnSwitchAxe.TabIndex = 8;
            this.chkWpnSwitchAxe.UseVisualStyleBackColor = true;
            // 
            // chkWpnGunlance
            // 
            this.chkWpnGunlance.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnGunlance.Checked = true;
            this.chkWpnGunlance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnGunlance.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnGunlanceSmall;
            this.chkWpnGunlance.Location = new System.Drawing.Point(43, 56);
            this.chkWpnGunlance.Name = "chkWpnGunlance";
            this.chkWpnGunlance.Size = new System.Drawing.Size(30, 30);
            this.chkWpnGunlance.TabIndex = 7;
            this.chkWpnGunlance.UseVisualStyleBackColor = true;
            // 
            // chkWpnLance
            // 
            this.chkWpnLance.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnLance.Checked = true;
            this.chkWpnLance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnLance.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnLanceSmall;
            this.chkWpnLance.Location = new System.Drawing.Point(7, 56);
            this.chkWpnLance.Name = "chkWpnLance";
            this.chkWpnLance.Size = new System.Drawing.Size(30, 30);
            this.chkWpnLance.TabIndex = 6;
            this.chkWpnLance.UseVisualStyleBackColor = true;
            // 
            // chkWpnHuntingHorn
            // 
            this.chkWpnHuntingHorn.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnHuntingHorn.Checked = true;
            this.chkWpnHuntingHorn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnHuntingHorn.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnHuntingHornSmall;
            this.chkWpnHuntingHorn.Location = new System.Drawing.Point(187, 20);
            this.chkWpnHuntingHorn.Name = "chkWpnHuntingHorn";
            this.chkWpnHuntingHorn.Size = new System.Drawing.Size(30, 30);
            this.chkWpnHuntingHorn.TabIndex = 5;
            this.chkWpnHuntingHorn.UseVisualStyleBackColor = true;
            // 
            // chkWpnHammer
            // 
            this.chkWpnHammer.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnHammer.Checked = true;
            this.chkWpnHammer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnHammer.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnHammerSmall;
            this.chkWpnHammer.Location = new System.Drawing.Point(151, 20);
            this.chkWpnHammer.Name = "chkWpnHammer";
            this.chkWpnHammer.Size = new System.Drawing.Size(30, 30);
            this.chkWpnHammer.TabIndex = 4;
            this.chkWpnHammer.UseVisualStyleBackColor = true;
            // 
            // chkWpnDualBlades
            // 
            this.chkWpnDualBlades.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnDualBlades.Checked = true;
            this.chkWpnDualBlades.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnDualBlades.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnDualBladesSmall;
            this.chkWpnDualBlades.Location = new System.Drawing.Point(115, 20);
            this.chkWpnDualBlades.Name = "chkWpnDualBlades";
            this.chkWpnDualBlades.Size = new System.Drawing.Size(30, 30);
            this.chkWpnDualBlades.TabIndex = 3;
            this.chkWpnDualBlades.UseVisualStyleBackColor = true;
            // 
            // chkWpnSwordAndShield
            // 
            this.chkWpnSwordAndShield.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnSwordAndShield.Checked = true;
            this.chkWpnSwordAndShield.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnSwordAndShield.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnSword_ShieldLarge;
            this.chkWpnSwordAndShield.Location = new System.Drawing.Point(79, 20);
            this.chkWpnSwordAndShield.Name = "chkWpnSwordAndShield";
            this.chkWpnSwordAndShield.Size = new System.Drawing.Size(30, 30);
            this.chkWpnSwordAndShield.TabIndex = 2;
            this.chkWpnSwordAndShield.UseVisualStyleBackColor = true;
            // 
            // chkWpnLongSword
            // 
            this.chkWpnLongSword.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnLongSword.Checked = true;
            this.chkWpnLongSword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnLongSword.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnLongSwordSmall;
            this.chkWpnLongSword.Location = new System.Drawing.Point(43, 20);
            this.chkWpnLongSword.Name = "chkWpnLongSword";
            this.chkWpnLongSword.Size = new System.Drawing.Size(30, 30);
            this.chkWpnLongSword.TabIndex = 1;
            this.chkWpnLongSword.UseVisualStyleBackColor = true;
            // 
            // chkWpnGreatSword
            // 
            this.chkWpnGreatSword.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWpnGreatSword.Checked = true;
            this.chkWpnGreatSword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWpnGreatSword.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnWpnGreatSwordSmall;
            this.chkWpnGreatSword.Location = new System.Drawing.Point(7, 20);
            this.chkWpnGreatSword.Name = "chkWpnGreatSword";
            this.chkWpnGreatSword.Size = new System.Drawing.Size(30, 30);
            this.chkWpnGreatSword.TabIndex = 0;
            this.chkWpnGreatSword.UseVisualStyleBackColor = true;
            // 
            // gbAmrFilters
            // 
            this.gbAmrFilters.Controls.Add(this.chkLegs);
            this.gbAmrFilters.Controls.Add(this.chkAmrWaist);
            this.gbAmrFilters.Controls.Add(this.chkAmrArms);
            this.gbAmrFilters.Controls.Add(this.chkAmrChest);
            this.gbAmrFilters.Controls.Add(this.chkAmrHead);
            this.gbAmrFilters.Controls.Add(this.btnAmrGender);
            this.gbAmrFilters.Location = new System.Drawing.Point(6, 19);
            this.gbAmrFilters.Name = "gbAmrFilters";
            this.gbAmrFilters.Size = new System.Drawing.Size(223, 60);
            this.gbAmrFilters.TabIndex = 0;
            this.gbAmrFilters.TabStop = false;
            this.gbAmrFilters.Text = "Armors";
            // 
            // chkLegs
            // 
            this.chkLegs.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLegs.Checked = true;
            this.chkLegs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLegs.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnAmrLegsSmall;
            this.chkLegs.Location = new System.Drawing.Point(151, 20);
            this.chkLegs.Name = "chkLegs";
            this.chkLegs.Size = new System.Drawing.Size(30, 30);
            this.chkLegs.TabIndex = 4;
            this.chkLegs.UseVisualStyleBackColor = true;
            // 
            // chkAmrWaist
            // 
            this.chkAmrWaist.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAmrWaist.Checked = true;
            this.chkAmrWaist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAmrWaist.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnAmrWaistSmall;
            this.chkAmrWaist.Location = new System.Drawing.Point(115, 20);
            this.chkAmrWaist.Name = "chkAmrWaist";
            this.chkAmrWaist.Size = new System.Drawing.Size(30, 30);
            this.chkAmrWaist.TabIndex = 3;
            this.chkAmrWaist.UseVisualStyleBackColor = true;
            // 
            // chkAmrArms
            // 
            this.chkAmrArms.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAmrArms.Checked = true;
            this.chkAmrArms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAmrArms.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnAmrArmsSmall;
            this.chkAmrArms.Location = new System.Drawing.Point(79, 20);
            this.chkAmrArms.Name = "chkAmrArms";
            this.chkAmrArms.Size = new System.Drawing.Size(30, 30);
            this.chkAmrArms.TabIndex = 2;
            this.chkAmrArms.UseVisualStyleBackColor = true;
            // 
            // chkAmrChest
            // 
            this.chkAmrChest.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAmrChest.Checked = true;
            this.chkAmrChest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAmrChest.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnAmrChestSmall;
            this.chkAmrChest.Location = new System.Drawing.Point(43, 20);
            this.chkAmrChest.Name = "chkAmrChest";
            this.chkAmrChest.Size = new System.Drawing.Size(30, 30);
            this.chkAmrChest.TabIndex = 1;
            this.chkAmrChest.UseVisualStyleBackColor = true;
            // 
            // chkAmrHead
            // 
            this.chkAmrHead.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAmrHead.Checked = true;
            this.chkAmrHead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAmrHead.Image = global::Hunting_List_for_MH3U.Properties.Resources.icnAmrHeadSmall;
            this.chkAmrHead.Location = new System.Drawing.Point(7, 20);
            this.chkAmrHead.Name = "chkAmrHead";
            this.chkAmrHead.Size = new System.Drawing.Size(30, 30);
            this.chkAmrHead.TabIndex = 0;
            this.chkAmrHead.UseVisualStyleBackColor = true;
            // 
            // btnAmrGender
            // 
            this.btnAmrGender.Location = new System.Drawing.Point(187, 20);
            this.btnAmrGender.Name = "btnAmrGender";
            this.btnAmrGender.Size = new System.Drawing.Size(30, 30);
            this.btnAmrGender.TabIndex = 5;
            this.btnAmrGender.TabStop = false;
            this.btnAmrGender.UseVisualStyleBackColor = true;
            this.btnAmrGender.Click += new System.EventHandler(this.btnAmrGender_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbFilters);
            this.Name = "MainForm";
            this.Text = "Hunting List for MH3U";
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.gbWpnFilters.ResumeLayout(false);
            this.gbAmrFilters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.GroupBox gbWpnFilters;
        private System.Windows.Forms.GroupBox gbAmrFilters;
        private System.Windows.Forms.Button btnAmrGender;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkLegs;
        private System.Windows.Forms.CheckBox chkAmrWaist;
        private System.Windows.Forms.CheckBox chkAmrArms;
        private System.Windows.Forms.CheckBox chkAmrChest;
        private System.Windows.Forms.CheckBox chkAmrHead;
        private System.Windows.Forms.CheckBox chkWpnBow;
        private System.Windows.Forms.CheckBox chkWpnHeavyBowgun;
        private System.Windows.Forms.CheckBox chkWpnLightBowgun;
        private System.Windows.Forms.CheckBox chkWpnSwitchAxe;
        private System.Windows.Forms.CheckBox chkWpnGunlance;
        private System.Windows.Forms.CheckBox chkWpnLance;
        private System.Windows.Forms.CheckBox chkWpnHuntingHorn;
        private System.Windows.Forms.CheckBox chkWpnHammer;
        private System.Windows.Forms.CheckBox chkWpnDualBlades;
        private System.Windows.Forms.CheckBox chkWpnSwordAndShield;
        private System.Windows.Forms.CheckBox chkWpnLongSword;
        private System.Windows.Forms.CheckBox chkWpnGreatSword;
    }
}

