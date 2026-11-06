using AURA.Models;

namespace AURA.Repositories;

public sealed class ProductRepository
{
    private static readonly Category Audio = new(
        "Аудио әлемі", "audio",
        "/images/headphones.jpg",
        "Әр сәтке арналған мөлдір дыбыс.");
    private static readonly Category Wearables = new(
        "Ақылды гаджеттер", "wearables",
        "/images/watch.jpg",
        "Күнделікті өмірге үйлескен технология.");
    private static readonly Category Workspace = new(
        "Жұмыс кеңістігі", "workspace",
        "/images/keyboard.jpg",
        "Ой мен іске шабыт беретін заттар.");

    private readonly IReadOnlyList<Product> _products =
    [
        new(1, "AURA Studio құлаққабы",
            "Теңгерімді дыбысы мен жұмсақ жастықшалары ұзақ тыңдауға жайлылық сыйлайды. Белсенді шуды басу технологиясы қала қарбаласында да сүйікті әуеніңізге толық енуге көмектеседі. Заряды 40 сағатқа дейін жетеді.",
            89_900m, Audio, "/images/headphones.jpg", true),
        new(2, "Form сағаты",
            "Жұқа металл корпусы мен анық AMOLED экраны кез келген стильге жарасады. Ұйқы мен белсенділікті бақылап, күнделікті маңызды көрсеткіштерді бір қарағанда көрсетеді. Су шашырауына төзімді, қуаты жеті күнге дейін сақталады.",
            124_900m, Wearables, "/images/watch.jpg", true),
        new(3, "Key 84 механикалық пернетақтасы",
            "Ықшам 84 пернелі пішім жұмыс үстелінде көбірек орын қалдырады. Жұмсақ басылатын механикалық қосқыштары мен реттелетін жарығы жайлы жұмыс ырғағын қалыптастырады. Bluetooth және USB-C арқылы қосылады.",
            74_900m, Workspace, "/images/keyboard.jpg", true),
        new(4, "Arc сымсыз тінтуірі",
            "Қолға табиғи орналасатын эргономикалық пішін күні бойғы жұмысты жеңілдетеді. Дәл сенсоры әртүрлі бетте тұрақты жұмыс істейді, ал тыныш батырмалары ортақ кеңістікте артық дыбыс шығармайды.",
            34_900m, Workspace, "/images/mouse.jpg", true),
        new(5, "Nomad портативті динамигі",
            "Шағын корпусына қарамастан, бөлмені қанық дыбыспен толтырады. Суға төзімді қабы мен 16 сағаттық қуаты оны саяхатқа да, үй ішіне де қолайлы етеді. Бірнеше құрылғыны кезекпен қосуға болады.",
            54_900m, Audio, "/images/speaker.jpg", false),
        new(6, "Rise алюминий тіреуіші",
            "Ноутбукты көз деңгейіне көтеріп, жұмыс орнын ұқыпты ұйымдастыруға көмектеседі. Жеңіл алюминийден жасалған берік құрылымы ауа айналымын жақсартады және көп модельмен үйлеседі.",
            39_900m, Workspace, "/images/stand.jpg", true)
    ];

    public IReadOnlyList<Product> GetAll() => _products;

    public Product? GetById(int id) => _products.FirstOrDefault(product => product.Id == id);

    public IReadOnlyList<Category> GetCategories() => [Audio, Wearables, Workspace];
}
