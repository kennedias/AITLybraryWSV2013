using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace SystemFramework
{
    public static class AppUtil
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            // Extract Property information
            PropertyDescriptorCollection propertyCollection = TypeDescriptor.GetProperties(typeof(T));

            // Create Empty DataTable
            DataTable dataTable = new DataTable();
            dataTable.TableName = "wsTable";


            // Add column to empty DataTable
            for (int i = 0; i < propertyCollection.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = propertyCollection[i];
                dataTable.Columns.Add(propertyDescriptor.Name, propertyDescriptor.PropertyType);
            }

            // Insert Data
            object[] rowsList = new object[propertyCollection.Count];

            foreach (T item in data)
            {
                for (int i = 0; i < rowsList.Length; i++)
                {
                    rowsList[i] = propertyCollection[i].GetValue(item);
                }

                dataTable.Rows.Add(rowsList);
            }

            return dataTable;
        }

        public static DataTable ThrowExceptionTable(Exception ex, string faultSource)
        {
            DataTable FormatedExceptionDataTable = new DataTable();

            FormatedExceptionDataTable.TableName = Constants.wsExTableName;
            FormatedExceptionDataTable.Columns.Add(Constants.wsExTableColumnFaultSourceDescription);
            FormatedExceptionDataTable.Columns.Add(Constants.wsExTableColumnFaultSourceCode);
            FormatedExceptionDataTable.Columns.Add(Constants.wsExTableColumnExType);
            FormatedExceptionDataTable.Columns.Add(Constants.wsExTableColumnExMessage);

            DataRow row = FormatedExceptionDataTable.NewRow();

            row[Constants.wsExTableColumnFaultSourceDescription] = faultSource;
            row[Constants.wsExTableColumnExType] = ex.GetType().ToString();
            row[Constants.wsExTableColumnExMessage] = ex.Message;


            //Identify the location of the FaultCode
            switch (faultSource)
            {
                case  Constants.faultBusinessError:
                    row[Constants.wsExTableColumnFaultSourceCode] = AppEnum.FaultSourceWS.BusinessError;
                    break;
                case Constants.faultAplicationError:
                    row[Constants.wsExTableColumnFaultSourceCode] = AppEnum.FaultSourceWS.AplicationError;
                    break;
            }

            FormatedExceptionDataTable.Rows.Add(row);

            return FormatedExceptionDataTable;
        }

        /*
        public static DataTable intToDataTable(int operationResult)
        {
            
            // Create Empty DataTable
            DataTable dataTable = new DataTable();
            dataTable.TableName = "wsTable";


            // Add column to empty DataTable
            for (int i = 0; i < propertyCollection.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = propertyCollection[i];
                dataTable.Columns.Add(propertyDescriptor.Name, propertyDescriptor.PropertyType);
            }

            // Insert Data
            object[] rowsList = new object[propertyCollection.Count];

            foreach (T item in data)
            {
                for (int i = 0; i < rowsList.Length; i++)
                {
                    rowsList[i] = propertyCollection[i].GetValue(item);
                }

                dataTable.Rows.Add(rowsList);
            }

            return dataTable;
        } 
        */
    }
}
