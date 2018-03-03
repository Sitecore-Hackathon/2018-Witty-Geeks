using Newtonsoft.Json;
using Sitecore.Data.Items;
using Sitecore.Globalization;
using Sitecore.Pipelines.GetContentEditorWarnings;
using System.Linq;
using System.Text;
using WittyGeeks.Hackathon.Foundation.SitecoreExtensions.Models.Json;

/// <summary>
/// This pipeline is used to show sticky notes on Content Editor if added from Experience Editor by an author. 
/// </summary>

namespace WittyGeeks.Hackathon.Foundation.SitecoreExtensions.Models.Extensions
{
    public class DisplayStickyNote
    {
        public void Process(GetContentEditorWarningsArgs args)
        {
            Item item = args.Item;
            // If Item is null return
            if (item == null)
            {
                return;
            }


            //Check if the current item has sticky notes
            if (item.Fields["StickyNotes"] != null && item.Fields["StickyNotes"].Value != null)
            {
                GetContentEditorWarningsArgs.ContentEditorWarning warning = args.Add();
                warning.Title = Translate.Text("Following are the sticky notes added to this item");
                StringBuilder warningText = new StringBuilder();
                string stickyNoteOnItem = item.Fields["StickyNotes"].Value.ToString();

                if (!string.IsNullOrEmpty(stickyNoteOnItem))
                {

                    //Read through all the sticky notes available on the item 
                    var stickyNotes = JsonConvert.DeserializeObject<StickyNotes>(stickyNoteOnItem);
                    if (stickyNotes != null && stickyNotes.notesOnAnItem != null && stickyNotes.notesOnAnItem.Any())
                    {
                        foreach (var note in stickyNotes.notesOnAnItem)
                        {
                            if (note.Properties != null && !string.IsNullOrEmpty(note.Properties.Text))
                            {
                                warningText.AppendFormat("{0} was added by {1} on {2}", note.Properties.Text, note.Properties.UserName, note.Properties.DateCreated);
                                warningText.Append("<br>");

                            }
                        }
                    }



                }
                //Assign  the sticky notes to the warning 
                warning.Text = warningText.ToString();
            }


        }
    }
}