using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EEKarta
{
    public partial class MainPage : ContentPage
    {
        ContentPage Harju, Rap, Laanem, IdVir;

        public object Children { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            Image img = new Image()
            {
                Source = "flag.jpg"

            };
            Button btn1 = new Button()
            {
                Text = "EESTI"
            };
            Button btn2 = new Button()
            {
                Text = "Harjumaa"
            };

            Button btn3 = new Button()
            {
                Text = "RAPLAMAA"
            };
            Button btn4 = new Button()
            {
                Text = "Laanemaa"
            };
            Button btn5 = new Button()
            {
                Text = "Ida-Virumaa"
            };

            StackLayout stack = new StackLayout
            {
                Children = { btn4, btn2, btn3, btn5 }
            };
            ContentPage content = new ContentPage();

            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            btn5.Clicked += Btn5_Clicked;


            stack.Children.Add(img);
            //stack.Children.Add(btn4);
            //stack.Children.Add(btn2);
            stack.Children.Add(btn1);
            //stack.Children.Add(btn3);
           //stack.Children.Add(btn5);


            content.Content = stack;

            Harju = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.FromHex("2296f3"),
                            Content = new Label { Text = "Tallinn", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))}

                        },
                        new Image
                        {
                            Source = "tal.jpg",
                        },
                         new Label
                        {
                            Text = "Харьюмаа — наиболее урбанизированный регион с максимальной плотностью населения." +
                            " В уезде насчитывается шесть городов, включая столицу молодой республики — город Таллин, основанный датскими поселенцами в 1219 году." +
                            " Местность впечатляет хорошей сохранностью построек XVIII–XIX века." +
                            " Для посетителей открыты исторические мызы Саку, Вихтерпалу и Сауэ, а также дворцово-парковый комплекс Вазалемма. "
                        },
                        btn2

                    },
                }
            };
            Rap = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.FromHex("2296f3"),
                            Content = new Label { Text = "Rapla", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))}

                        },
                        new Image
                        {
                            Source = "rapla.jpg",
                        },
                        new Label
                        {
                            Text = " Культурное наследие уезда Рапламаа в меньшей степени пострадало от исторических катаклизмов. " +
                            "Ключевой экскурсионный маршрут носит название «Золотое кольцо имений Рапламаа». " +
                            "В программу туров входит посещения усадеб Райккюла, Атла, Тохисоо, Хагуди, Рюютли и Кехтла. " +
                            "В городах Рапла, Вигала, Кохила и Юуру сохранились лютеранские церкви и часовни, построенные шведскими и немецкими вельможами.. "
                        },
                        btn3
                        

                    },
                }
            };
            Laanem = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.FromHex("2296f3"),
                            Content = new Label { Text = "Haapsalu", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))}

                        },
                        new Image
                        {
                            Source = "haap.jpg",
                        },
                         new Label
                        {
                            Text = "Парадной витриной уезда Ляэнемаа служит старинный город Хаапсалу, " +
                            "с трёх сторон окружённый морем. В 1825 году здесь открылась первая грязелечебница страны, " +
                            "а на приморском променаде сохранился курзал конца XIX века с концертной раковиной, украшенный искусной резьбой по дереву.. "
                        },

                         btn4
                        

                    },
                }
            };
            IdVir = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.FromHex("2296f3"),
                            Content = new Label { Text = "Ontika", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))}

                        },
                        new Image
                        {
                            Source = "ont.jpg",
                        },
                         new Label
                        {
                            Text = ".Ида-Вирумаа — территория рекордов." +
                            " Северо-западную часть региона занимает глинт Онтика — самый высокий в Балтии, возраст которого оценивается в 470–570 миллионов лет." +
                            " С уступа высотой 30,5 метров несутся бурные потоки рукотворного водопада Валасте, прозванного «эстонской Ниагарой». " +
                            "Каскад Валасте считается самым высоким водопадом в Прибалтике. "
                        },
                         btn5
                        

                    },
                }
            };
            //Children.Add(content);

        }
        
        private  void Btn5_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://tripmydream.com/estonia/regions");
            //object IdVir = await BrowsableAttribute;
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://tripmydream.com/estonia/regions");
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://tripmydream.com/estonia/regions");
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
             Uri uri = new Uri("https://tripmydream.com/estonia/regions");
        }

        



        

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            
           // this.Children.Remove(Harju);
           // this.Children.Remove(Rap);
           // this.Children.Remove(Laanem);
           // this.Children.Add(IdVir);



        }
    }
}
