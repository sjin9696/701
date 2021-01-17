namespace Storagy
{
    class Product
    {
        public static Product temporary_Product = new Product();
        //코드
        public string code { get; set; }
        //품명
        public string name { get; set; }
        //분류
        public string categorize { get; set; }
        //규격
        public string type { get; set; }
        //입고업체
        public string buy_company { get; set; }
        //입고일자
        public string buy_date { get; set; }
        //입고가격
        public string buy_money { get; set; }
        //보관위치
        public string storage_location { get; set; }
        //보관수량
        public string storage_quantity { get; set; }
        //출고가격
        public string sales_money { get; set; }
        //출고일자
        public string sales_dates { get; set; }
        //출고납품업체
        public string sales_company { get; set; }
    }
}
