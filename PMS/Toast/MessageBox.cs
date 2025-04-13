using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Toast
{
    public static class MessageBox
    {
        private static void ShowToast(Form parentForm,string message, ToastType type = ToastType.Info)
        {
            ToastForm toast = new ToastForm(message, type,parentForm);
            toast.Show();
        }

        public static void ShowInfoMessage(Form parentForm,string message)
        {
            ShowToast(parentForm,message, ToastType.Info);
        }

        public static void ShowErrorMessage(Form parentForm, string message)
        {
            ShowToast(parentForm,message, ToastType.Error);
        }

        public static void ShowSuccessMessage(Form parentForm, string message)
        {
            ShowToast(parentForm,message, ToastType.Success);
        }

        public static void ShowWarningMessage(Form parentForm, string message)
        {
            ShowToast(parentForm,message, ToastType.Warning);
        }

        
    }
}
