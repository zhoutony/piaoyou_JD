// ===================================================================
//  文件名:		NPOIExcelResult.cs
//  版权:		Copyright (C) 2010 Piaoyou
//  创建人:		tony.zhou
//  创建日期:		2015-08-15 14:21
//  描述:		采用NPOI导出Excel
//  备注:		
// ===================================================================

using System.Data;
using System.IO;
using System.Text;
using Mtime.Web;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace JD.MovieAPI.MVC
{
    /// <summary>
    /// 采用NPOI导出Excel
    /// </summary>
    public class NPOIExcelResult : ActionResult
    {
        public string FileName { get; set; }
        private HSSFWorkbook hssfWorkbook;

        public NPOIExcelResult(string fileName,HSSFWorkbook workbook)
        {
            FileName = fileName;
            hssfWorkbook = workbook;
        }

        public NPOIExcelResult(string fileName, DataTable table)
        {
            FileName = fileName;
            hssfWorkbook = new HSSFWorkbook();
            Sheet sheet = hssfWorkbook.CreateSheet();
            
            //填充表头   
            Row dataRow = sheet.CreateRow(0);
            foreach (DataColumn column in table.Columns)
            {
                dataRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);
            }
            
            //填充内容   
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dataRow = sheet.CreateRow(i + 1);
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    Cell cell = dataRow.CreateCell(j);
                    cell.SetCellType(CellType.STRING);
                    double value = -1.0;
                    var convertFlag = double.TryParse(table.Rows[i][j].ToString(), out value);
                    if (convertFlag)
                    {
                        cell.SetCellValue(value);
                    }
                    else
                    {
                        cell.SetCellValue(table.Rows[i][j].ToString());
                    }
                }
            }
        }

        public override void Execute(RequestContext rc)
        {
            rc.Context.Response.Buffer = false;
            rc.Context.Response.Clear();
            string filename = string.Format("{0}", FileName);
            rc.Context.Response.AppendHeader("Content-Disposition", "attachment;filename=" + filename);
            rc.Context.Response.Charset = "GB2312";
            rc.Context.Response.ContentType = "application/vnd.ms-excel";
            rc.Context.Response.ContentEncoding = Encoding.GetEncoding("gb2312");
            hssfWorkbook.Write(rc.Context.Response.OutputStream);
       }
    }
}
