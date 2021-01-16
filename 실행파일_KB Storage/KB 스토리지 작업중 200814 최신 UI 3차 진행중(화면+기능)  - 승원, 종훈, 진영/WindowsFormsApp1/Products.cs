namespace Storagy
{
    class Product
    {
        //코드
        public string code { get; set; }
        //품명
        public string name { get; set; }
        //분류
        public string categorize { get; set; }
        //규격
        public string type { get; set; }
        //작업자
        public string buy_company { get; set; }
        //납품처
        public string buy_date { get; set; }
        //납품일자
        public string buy_money { get; set; }
        //금액
        public string storage_location { get; set; }
        //보관위치
        public string storage_quantity { get; set; }
        //재고수량
        public string sales_money { get; set; }
        //판매수량
        public string sales_dates { get; set; }
        //판매수량
        public string sales_company { get; set; }
    }
}
