using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB_Storagy_Project_WindowsFormsApp
{
    class Products
    {
        //코드
        public string product_code_number { get; set; }
        //품명
        public string product_name { get; set; }
        //분류
        public string categorize_name { get; set; }
        //규격
        public string type_name { get; set; }
        //바코드
        public string barcode_number { get; set; }
        //판매수량
        public string sales_number { get; set; }
        //금액
        public string money_number { get; set; }
        //입고일
        public string delivery_day { get; set; }
        //납품처
        public string customer_name { get; set; }
        //보관위치
        public string storage_name { get; set; }
        //재고수량
        public string inventory_stock_number { get; set; }
        //작업자
        public string worker_name { get; set; }
    }
}
