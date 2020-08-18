using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlDataManager
{
    class Product
    {
        //코드
        public string product_code_number { get; set; }
        //품명
        public string product_name { get; set; }
        //분류
        public string categorize_name { get; set; }
        //규격
        public string type_name { get; set; }
        //작업자
        public string worker_name { get; set; }
        //납품처
        public string customer_name { get; set; }
        //납품일자
        public string delivery_dates { get; set; }
        //금액
        public string money_number { get; set; }
        //보관위치
        public string storage_name { get; set; }
        //재고수량
        public string storage_inventoy_number { get; set; }
        //판매수량
        public string sales_money_number { get; set; }
        //판매일자
        public string sales_dates { get; set; }
    }
}
