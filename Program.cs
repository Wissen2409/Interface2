// See https://aka.ms/new-console-template for more information

// interface'i new ile ömrnekleyebilir miyim  ? Interface ieçrisinde metotların sadece imzası olduğu için
// nesne örneklense bile, üyeleri tam olmadığı için nesne üretimi engellenmiştir.!!!!
//IHavaTasit tasit =new IHavaTasit();

// interface tipinde bir dizi yapabilirsiniz!!!!
IHavaTasit[] havaTasit = new IHavaTasit[10];
havaTasit[0]=new HoverCraft();

// dizinin her bir index'inde, bir interface tipinde bir pointer var, 
// bu pointerlere new derseniz interface tipindeki pointerlar, onlardan katılım alınan sınıflara ait nesneleri
// işaret edeler!!!!

static void Test(){

    IHavaTasit havaTasit=new HoverCraft();
}
