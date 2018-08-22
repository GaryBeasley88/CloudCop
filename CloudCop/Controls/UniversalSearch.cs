using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors.Controls;

namespace CloudCop.Controls
{
    public partial class UniversalSearch : DevExpress.XtraEditors.XtraUserControl
    {
        public UniversalSearch()
        {
            InitializeComponent();
        }

        private void UniversalSearch_Load(object sender, EventArgs e)
        {
            AddSearchTypes();
            AddSearchContainers();
        }

        public void AddSearchTypes()
        {
            RadioGroupItem item1 = new RadioGroupItem(0, "Cases", true);
            RadioGroupItem item2 = new RadioGroupItem(0, "Persons", true);
            RadioGroupItem item3 = new RadioGroupItem(0, "Articles", true);
            RadioGroupItem item4 = new RadioGroupItem(0, "Vehicles", true);
            RadioGroupItem item5 = new RadioGroupItem(0, "Locations", true);

            searchType.Properties.Items.Add(item1);
            searchType.Properties.Items.Add(item2);
            searchType.Properties.Items.Add(item3);
            searchType.Properties.Items.Add(item4);
            searchType.Properties.Items.Add(item5);

            searchType.EditValue = 0;

        }

        public void AddSearchContainers()
        {
            // add Search group
            AccordionControlElement groupSearch = new AccordionControlElement();
            groupSearch.Style = ElementStyle.Group;
            groupSearch.Name = "GROUP1";
            groupSearch.HeaderVisible = false;
            groupSearch.Expanded = true;
            groupSearch.Text = "Search Fields Group";

            accordionControl.Elements.Add(groupSearch);

            AddNewItem(groupSearch, "Case Number", "SEARCH_CASE");
            groupSearch.Elements["SEARCH_CASE"].Style = ElementStyle.Group;
            AddSearchContainer(groupSearch.Elements["SEARCH_CASE"], "SEARCHCASE");

            //AddNewItem(groupSearch, "Search Fields", "SEARCH_FIELDS");
            //groupSearch.Elements["SEARCH_FIELDS"].Style = ElementStyle.Group;
            //AddSearchContainer(groupSearch.Elements["SEARCH_FIELDS"], "SEARCHFIELDS");

            //AddNewItem(groupSearch, "Report Type", "SEARCH_REPTYPE");
            //groupSearch.Elements["SEARCH_REPTYPE"].Style = ElementStyle.Group;
            //AddSearchContainer(groupSearch.Elements["SEARCH_REPTYPE"], "SEARCHREPTYPE");

            //AddNewItem(groupSearch, "Weapon Type", "SEARCH_WEAPONTYPE");
            //groupSearch.Elements["SEARCH_WEAPONTYPE"].Style = ElementStyle.Group;
            //AddSearchContainer(groupSearch.Elements["SEARCH_WEAPONTYPE"], "SEARCHWEAPONTYPE");

            //AddNewItem(groupSearch, "Officers", "SEARCH_OFFICERS");
            //groupSearch.Elements["SEARCH_OFFICERS"].Style = ElementStyle.Group;
            //AddSearchContainer(groupSearch.Elements["SEARCH_OFFICERS"], "SEARCHOFFICERS");

            //AddNewItem(groupSearch, "Violations", "SEARCH_VIOLATIONS");
            //groupSearch.Elements["SEARCH_VIOLATIONS"].Style = ElementStyle.Group;
            //AddSearchContainer(groupSearch.Elements["SEARCH_VIOLATIONS"], "SEARCHVIOLATIONS");

        }

        public void AddNewItem(AccordionControlElement GroupName, string ElementText, string ElementName)
        {
            AccordionControlElement NewElement = new AccordionControlElement()
            {
                Style = ElementStyle.Item,
                Text = ElementText,
                Name = ElementName,
                Expanded = true
                
            };
            GroupName.Elements.Add(NewElement);
        }

        public void AddSearchContainer(AccordionControlElement GroupName, string elementName)
        {
            AccordionControlElement element = new AccordionControlElement();
            element.Style = ElementStyle.Item;
            element.HeaderVisible = false;
            element.Name = elementName;
            element.ContentContainer = new AccordionContentContainer();

            Control cntrl = null;
            switch (elementName)
            {
                case "SEARCHCASE":
                    cntrl = new USearch_Case();
                    break;
                    //    case "SEARCHFIELDS":
                    //        cntrl = new Search_Fields();
                    //        break;
                    //    case "SEARCHREPTYPE":
                    //        cntrl = new Search_ReportTypes();
                    //        break;
                    //    case "SEARCHWEAPONTYPE":
                    //        cntrl = new Search_WeaponType();
                    //        break;
                    //    case "SEARCHOFFICERS":
                    //        cntrl = new Search_Officers();
                    //        break;
                    //    case "SEARCHVIOLATIONS":
                    //        cntrl = new Search_Violations();
                    //        break;
            }

            element.ContentContainer.Height = cntrl.Height;
            element.ContentContainer.Width = cntrl.Width;
            element.ContentContainer.Controls.Add(cntrl);
            element.ContentContainer.Controls[0].Dock = DockStyle.Fill;

            GroupName.Elements.Add(element); // THIS LINE
        }

        private void searchType_EditValueChanged(object sender, EventArgs e)
        {
            // Based on the selection, load the appropriate control in the accordioncontrol
        }
    }
}
