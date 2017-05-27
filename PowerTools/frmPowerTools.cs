using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32;
using PowerToolsHelper;


namespace PowerTools
{

    //public struct RegistryValue
    //{
    //    RegistryValueKind m_rvkValue;
    //    object m_objValue;
    //    string m_strDescription;
    //};
    //
    //public class PowerToolOption
    //{
    //    string m_strAppliesTo = ""; //
    //    string m_strRegistryKey = "";
    //    RegistryValue[] m_RegistryValues = null;
    //    uint m_uiMinVersion = 0;
    //    uint m_uiMaxVersion = 0;
    //};



    public partial class frmPowerTools : Form
    {
        public frmPowerTools()
        {
            InitializeComponent();

            InstalledProduct[] ipList = PowerToolsHelper.PowerToolsHelper.GetListOfInstalledProducts();


            foreach (InstalledProduct Product in ipList)
            {
                dataGridView1.Rows.Add(new object[] { Product.m_strName, Product.m_strPath, Product.m_uiVersionMajor, Product.m_uiVersionMinor, Product.m_strGUID });
            }


        }

        private void rbEnableOfficeStoreAddinNo_CheckedChanged(object sender, EventArgs e)
        {
            String[] arrEnableOfficeStoreSubkey = { "Software", "Microsoft", "Office", "16.0", "Outlook", "Options", "Webext" };
            string strOpenSubkey = "";
            RegistryKey rkOpenSubkey = null;
            int iKeyValue = -1;

            //Validate and attempt to create path for desired subkey
            foreach( string strSubkey in arrEnableOfficeStoreSubkey)
            {
                strOpenSubkey += strSubkey + "\\";

                rkOpenSubkey = Registry.CurrentUser.OpenSubKey(strOpenSubkey,true);

                //Validate path for subkey, create if it doesn't exist
                if( rkOpenSubkey == null )
                {
                    Console.WriteLine("Failed to open user Subkey: " + strOpenSubkey);

                    //Attempt to create subkey
                    rkOpenSubkey = Registry.CurrentUser.CreateSubKey(strOpenSubkey, RegistryKeyPermissionCheck.ReadWriteSubTree);

                    if( rkOpenSubkey != null )
                    {
                        Console.WriteLine("Created a new current user Subkey: " + strOpenSubkey);
                    }
                    else
                    {
                        Console.WriteLine("Failed to create a current user Subkey: " + strOpenSubkey);
                        return;
                    }
                }
            }

            //Get the value of the opened subkey
            iKeyValue = (int)rkOpenSubkey.GetValue("StoreButtonInRibbonHomeTabAllowed", -1);

            //If default value of -1 was returned then the key doesn't exist create the key and set the value
            if(iKeyValue == -1 || iKeyValue == 1)
            {
                //Create Key / Value pair
                rkOpenSubkey.SetValue("StoreButtonInRibbonHomeTabAllowed", 0);
                //Close the registry subkey
                rkOpenSubkey.Close();
            }

        }

        private void rbEnableOfficeStoreAddinYes_CheckedChanged(object sender, EventArgs e)
        {
            String[] arrEnableOfficeStoreSubkey = { "Software", "Microsoft", "Office", "16.0", "Outlook", "Options", "Webext" };
            string strOpenSubkey = "";
            RegistryKey rkOpenSubkey = null;
            int iKeyValue = -1;

            //Validate and attempt to create path for desired subkey
            foreach (string strSubkey in arrEnableOfficeStoreSubkey)
            {
                strOpenSubkey += strSubkey + "\\";

                rkOpenSubkey = Registry.CurrentUser.OpenSubKey(strOpenSubkey, true);

                //Validate path for subkey, create if it doesn't exist
                if (rkOpenSubkey == null)
                {
                    Console.WriteLine("Failed to open user Subkey: " + strOpenSubkey);

                    //Attempt to create subkey
                    rkOpenSubkey = Registry.CurrentUser.CreateSubKey(strOpenSubkey, RegistryKeyPermissionCheck.ReadWriteSubTree);

                    if (rkOpenSubkey != null)
                    {
                        Console.WriteLine("Created a new current user Subkey: " + strOpenSubkey);
                    }
                    else
                    {
                        Console.WriteLine("Failed to create a current user Subkey: " + strOpenSubkey);
                        return;
                    }
                }
            }

            //Get the value of the opened subkey
            iKeyValue = (int)rkOpenSubkey.GetValue("StoreButtonInRibbonHomeTabAllowed", -1);

            //If default value of -1 was returned then the key doesn't exist create the key and set the value
            if (iKeyValue == -1 || iKeyValue == 1)
            {
                //Create Key / Value pair
                rkOpenSubkey.SetValue("StoreButtonInRibbonHomeTabAllowed", 1);
                //Close the registry subkey
                rkOpenSubkey.Close();
            }
        }

        private void frmPowerTools_Load(object sender, EventArgs e)
        {

        }

    }
}
