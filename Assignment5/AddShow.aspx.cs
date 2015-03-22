using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VenueAddShowService;

public partial class AddShow : System.Web.UI.Page
{
    VenueAddShowServiceClient nsc = new VenueAddShowServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["venuekey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        if (!IsPostBack)
        {
            FillDropDownListArtist();
        }
        SetArtistInvisible();
    }

    private void FillDropDownListArtist()
    {

        List<Artist> artists = nsc.GetArtist().ToList();
        DropDownListArtist.DataSource = artists;
        DropDownListArtist.DataTextField = "ArtistName";
        DropDownListArtist.DataValueField = "ArtistKey";
        DropDownListArtist.DataBind();
        //adding a new item to the list
        ListItem item = new ListItem("New Artist");
        DropDownListArtist.Items.Add(item);
    }

    private void SetArtistInvisible()
    {
        TableArtist.Visible = false;
        artistKey1.Visible = false;
        artistKey2.Visible = false;
    }
    protected void DropDownListArtist_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!DropDownListArtist.SelectedItem.Text.Equals("New Artist"))
        {
            lblArtistKey.Text = DropDownListArtist.SelectedItem.Value.ToString();
        }
        else
        {
            TableArtist.Visible = true;
        }
    }
    protected void btnAddArtist_Click(object sender, EventArgs e)
    {
        Artist a = new Artist();
        a.ArtistName = txtArtistName.Text;
        a.ArtistEmail = txtArtistEmail.Text;
        a.ArtistWebPage = txtWebSite.Text;
        bool result = nsc.AddArtist(a);
        if (!result)
        {
            Label1.Text = "there was a problem Saving the artist";
        }
        else
        {
            FillDropDownListArtist();
            Label1.Text = "Save And choose the artist from the drop down List";
        }
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        int vKey = (int)Session["venueKey"];
        DateTime shDate = Calendar1.SelectedDate;
        Show s = new Show();
        s.ShowName = txtShowName.Text;
        s.ShowDate = shDate;
        s.VenueKey = vKey;
        s.ShowTime = TimeSpan.Parse(txtTime.Text);
        s.ShowTicketInfo = txtInfo.Text;

        ShowDetail sd = new ShowDetail();
        sd.ArtistKey = int.Parse(lblArtistKey.Text);
        sd.ShowDetailArtistStartTime = TimeSpan.Parse(txtArtistStart.Text);
        sd.ShowDetailAdditional = txtAdditional.Text;

        bool result = nsc.AddShow(s, sd);
        if (!result)
        {
            lblResult.Text = "Show was not entered";
        }
        else
        {
            lblResult.Text = "Show was Saved";
        }
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session["venuekey"] = 0;
        Response.Redirect("Goodbye.aspx");
    }
}