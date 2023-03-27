namespace Lab9ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieti un program care va modela conturi bancare. Un cont bancar poate fi cont de economii,
cont de investitii sau cont curent si va fi caracterezat de un nume.
• In toate conturile vom putea depune bani.
 La depunerea banilor soldul curent va crește cu valoarea depusa
Din toate conturile vom putea extrage bani
 În situatia in care suma ceruta depașește soldul curent, pe ecran va fi afișat un mesaj
corespunzator iar suma nu va fi extrasa.
• Contul curent
 La extragerea numerarului dintr-un cont curent, in cazul in care suma extrasa este mai mare
decat cea disponibila in cont, contul va permite descoperirea de cont in limita plafonului de 5000
ron.
 Daca suma ceruta depaseste plafonul descoperirii de cont, atunci pe ecran va fi afișat un mesaj
corespunzator iar suma nu va fi extrasa.
• Contul de economii
 Este carecterizat de o rata a dobanzii.
 Dupa fiecare depunere, soldul contului de economii va fi reactualizat tinandu-se cont de rata
dobanzii :
 ValoareSold = ValoareSold*(1+rataDobanzii)
             Contul de investiții este un cont bancar care se comportă precum un cont de
economii, cu mențiunea ca extragerea banilor este posibila abia dupa
atingerea termenului de extragere
 La deschiderea unui cont de investitii, ziua termenului de extragere va fi specificat
sub forma unui intreg (1-31)
 Dacă se incearcă extragerea banilor înainte de termen, contul va afișa un mesaj
corespunzător iar suma nu va fi extrasa din cont.
 Ziua curenta poate fi determinate folosind: DateTime.Now.Day
• Toate conturile vor pune la dispozitie descrierea acestora. Descrierea va
contine toate detaliile relevante ale contului (nume, tip, sold curent, rata
dobanzii, ziua termenului de extragere, etc)
• Suplimentar
 Conturile vor avea cate un id unic de tip Guid (folositi google). Id-ul va fi atribuit
automat fiecarui cont la creare si va fi expus in descrierea contului.
• Implementati clasele, instantiati obiecte si apelati-le metodele.
             */


            BankAccount InvestmentsAccount = new InvestmentsAccount(25, 4.20m);

            InvestmentsAccount.DepositCash(25m);
            InvestmentsAccount.ToString();

            InvestmentsAccount.WithdrawCash(26m);
        }
    }
}
