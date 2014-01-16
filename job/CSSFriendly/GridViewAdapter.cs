using System;
using System.Collections;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace CSSFriendly
{
    public class GridViewAdapter : System.Web.UI.WebControls.Adapters.WebControlAdapter
    {
        private WebControlAdapterExtender _extender = null;
        private WebControlAdapterExtender Extender
        {
            get
            {
                if (((_extender == null) && (Control != null)) ||
                    ((_extender != null) && (Control != _extender.AdaptedControl)))
                {
                    _extender = new WebControlAdapterExtender(Control);
                }

                System.Diagnostics.Debug.Assert(_extender != null, "Unknown Error", "Null extender instance");
                return _extender;
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////
        /// PROTECTED        

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            if (Extender.AdapterEnabled)
            {
                RegisterScripts();
            }
        }

        protected override void RenderBeginTag(HtmlTextWriter writer)
        {
            if (Extender.AdapterEnabled)
            {
                Extender.RenderBeginTag(writer, "CustomGridView");
            }
            else
            {
                base.RenderBeginTag(writer);
            }
        }

        protected override void RenderEndTag(HtmlTextWriter writer)
        {
            if (Extender.AdapterEnabled)
            {
                Extender.RenderEndTag(writer);
            }
            else
            {
                base.RenderEndTag(writer);
            }
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            if (Extender.AdapterEnabled)
            {
                GridView gridView = Control as GridView;
                if (gridView != null)
                {
                    writer.Indent++;
                    WritePagerSection(writer, PagerPosition.Top);

                    writer.WriteLine();
                    writer.WriteBeginTag("div");
                    //writer.WriteAttribute("cellpadding", "0");
                    //writer.WriteAttribute("cellspacing", "0");
                    //writer.WriteAttribute("summary", Control.ToolTip);

                    if (!String.IsNullOrEmpty(gridView.CssClass))
                    {
                        writer.WriteAttribute("class", gridView.CssClass);
                    }

                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Indent++;

                    ArrayList rows = new ArrayList();
                    GridViewRowCollection gvrc = null;

                    ///////////////////// HEAD /////////////////////////////

                    rows.Clear();
                    if (gridView.ShowHeader && (gridView.HeaderRow != null))
                    {
                        rows.Add(gridView.HeaderRow);
                    }
                    gvrc = new GridViewRowCollection(rows);
                    WriteRows(writer, gridView, gvrc, "div");

                    ///////////////////// FOOT /////////////////////////////

                    rows.Clear();
                    if (gridView.ShowFooter && (gridView.FooterRow != null))
                    {
                        rows.Add(gridView.FooterRow);
                    }
                    gvrc = new GridViewRowCollection(rows);
                    WriteRows(writer, gridView, gvrc, "div");

                    ///////////////////// BODY /////////////////////////////

                    WriteRows(writer, gridView, gridView.Rows, "div");

                    ////////////////////////////////////////////////////////

                    writer.Indent--;
                    writer.WriteLine();
                    writer.WriteEndTag("div");

                    WritePagerSection(writer, PagerPosition.Bottom);

                    writer.Indent--;
                    writer.WriteLine();
                }
            }
            else
            {
                base.RenderContents(writer);
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////
        /// PRIVATE        

        private void RegisterScripts()
        {
        }

        private void WriteRows(HtmlTextWriter writer, GridView gridView, GridViewRowCollection rows, string tableSection)
        {
            if (rows.Count > 0)
            {
                writer.WriteLine();
                writer.WriteBeginTag(tableSection);
                writer.Write(HtmlTextWriter.TagRightChar);
                writer.Indent++;

                foreach (GridViewRow row in rows)
                {
                    writer.WriteLine();
                    writer.WriteBeginTag("div");

                    string className = GetRowClass(gridView, row);
                    if (!String.IsNullOrEmpty(className))
                    {
                        writer.WriteAttribute("class", className);
                    }

                    //  Uncomment the following block of code if you want to add arbitrary attributes.
                    /*
                    foreach (string key in row.Attributes.Keys)
                    {
                        writer.WriteAttribute(key, row.Attributes[key]);
                    }
                    */

                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Indent++;

                    foreach (TableCell cell in row.Cells)
                    {
                        DataControlFieldCell fieldCell = cell as DataControlFieldCell;
                        if ((fieldCell != null) && (fieldCell.ContainingField != null))
                        {
                            DataControlField field = fieldCell.ContainingField;
                            if (!field.Visible)
                            {
                                cell.Visible = false;
                            }

                            if ((field.ItemStyle != null) && (!String.IsNullOrEmpty(field.ItemStyle.CssClass)))
                            {
                                if (!String.IsNullOrEmpty(cell.CssClass))
                                {
                                    cell.CssClass += " ";
                                }
                                cell.CssClass += field.ItemStyle.CssClass;
                            }
                        }

                        writer.WriteLine();
                        cell.RenderControl(writer);
                    }

                    writer.Indent--;
                    writer.WriteLine();
                    writer.WriteEndTag("div");
                }

                writer.Indent--;
                writer.WriteLine();
                writer.WriteEndTag(tableSection);
            }
        }

        private string GetRowClass(GridView gridView, GridViewRow row)
        {
            string className = "";

            if ((row.RowState & DataControlRowState.Alternate) == DataControlRowState.Alternate)
            {
                className += " CustomGridViewAlt ";
                if (gridView.AlternatingRowStyle != null)
                {
                    className += gridView.AlternatingRowStyle.CssClass;
                }
            }
            else if (row.Equals(gridView.HeaderRow) && (gridView.HeaderStyle != null) && (!String.IsNullOrEmpty(gridView.HeaderStyle.CssClass)))
            {
                className += " " + gridView.HeaderStyle.CssClass;
            }
            else if (row.Equals(gridView.FooterRow) && (gridView.FooterStyle != null) && (!String.IsNullOrEmpty(gridView.FooterStyle.CssClass)))
            {
                className += " " + gridView.FooterStyle.CssClass;
            }
            else if ((gridView.RowStyle != null) && (!String.IsNullOrEmpty(gridView.RowStyle.CssClass)))
            {
                className += " " + gridView.RowStyle.CssClass;
            }

            if ((row.RowState & DataControlRowState.Edit) == DataControlRowState.Edit)
            {
                className += " CustomGridViewEdit ";
                if (gridView.EditRowStyle != null)
                {
                    className += gridView.EditRowStyle.CssClass;
                }
            }

            if ((row.RowState & DataControlRowState.Insert) == DataControlRowState.Insert)
            {
                className += " CustomGridViewInsert ";
            }

            if ((row.RowState & DataControlRowState.Selected) == DataControlRowState.Selected)
            {
                className += " CustomGridViewSelected ";
                if (gridView.SelectedRowStyle != null)
                {
                    className += gridView.SelectedRowStyle.CssClass;
                }
            }

            return className.Trim();
        }

        private void WritePagerSection(HtmlTextWriter writer, PagerPosition pos)
        {
            GridView gridView = Control as GridView;
            if ((gridView != null) &&
                gridView.AllowPaging &&
                ((gridView.PagerSettings.Position == pos) || (gridView.PagerSettings.Position == PagerPosition.TopAndBottom)))
            {
                Table innerTable = null;
                if ((pos == PagerPosition.Top) &&
                    (gridView.TopPagerRow != null) &&
                    (gridView.TopPagerRow.Cells.Count == 1) &&
                    (gridView.TopPagerRow.Cells[0].Controls.Count == 1) &&
                    typeof(Table).IsAssignableFrom(gridView.TopPagerRow.Cells[0].Controls[0].GetType()))
                {
                    innerTable = gridView.TopPagerRow.Cells[0].Controls[0] as Table;
                }
                else if ((pos == PagerPosition.Bottom) &&
                    (gridView.BottomPagerRow != null) &&
                    (gridView.BottomPagerRow.Cells.Count == 1) &&
                    (gridView.BottomPagerRow.Cells[0].Controls.Count == 1) &&
                    typeof(Table).IsAssignableFrom(gridView.BottomPagerRow.Cells[0].Controls[0].GetType()))
                {
                    innerTable = gridView.BottomPagerRow.Cells[0].Controls[0] as Table;
                }

                if ((innerTable != null) && (innerTable.Rows.Count == 1))
                {
                    string className = "PagerStyle";
                    className += (pos == PagerPosition.Top) ? "Top " : "Bottom ";
                    if (gridView.PagerStyle != null)
                    {
                        className += gridView.PagerStyle.CssClass;
                    }
                    className = className.Trim();

                    writer.WriteLine();
                    writer.WriteBeginTag("div");
                    writer.WriteAttribute("class", className);
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Indent++;

                    TableRow row = innerTable.Rows[0];

                    if (row.Cells.Count > 1)
                    {
                        foreach (TableCell cell in row.Cells)
                        {
                            foreach (Control ctrl in cell.Controls)
                            {
                                writer.WriteLine();
                                ctrl.RenderControl(writer);
                            }
                        }
                    }

                    writer.Indent--;
                    writer.WriteLine();
                    writer.WriteEndTag("div");
                }
            }
        }
    }
}