using MauiApp1.Clases;


namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private bool sedanInfoVisible = false;
    private bool pickUpInfoVisible = false;
    private bool suvInfoVisible = false;
    private bool cuatroPorCuatroInfoVisible = false;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (sedanInfoVisible)
        {
            sedanInfoVisible = false;
            sedanLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Sedan sedan = new Sedan();
            sedan.Marca = "Honda";
            sedan.Modelo = "Nuevo";
            sedan.Color = "Rojo";
            sedan.Anio = 2024;
            sedan.Placa = "DHYEBD";
            sedan.Tipo = "CRV";
            sedan.sillones = 4;
            sedan.ventanas= "si";
            sedan.aireacondicionado = "si";

            sedan.Encender();
            sedan.Acelerar(56);
            sedan.Bocina();
            sedan.radio();
            sedan.Apagar();

            string sedanInfo = $"Marca: {sedan.Marca}\nModelo: {sedan.Modelo}\nColor: {sedan.Color}\nAño: {sedan.Anio}\nPlaca: {sedan.Placa}\nTipo: {sedan.Tipo}\nSillones:{sedan.sillones}\nVentanas:{sedan.ventanas}\nAireAcondicionado:{sedan.aireacondicionado} ";
            sedanLabel.Text = sedanInfo; // Muestra la información

            sedanInfoVisible = true;
        }
    }
    private void OnCounterClicked1(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            pickUpInfoVisible = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            PickUp pickUp = new PickUp();
            pickUp.Marca = "Dmax";
            pickUp.Modelo = "Nuevo";
            pickUp.Color = "Negro";
            pickUp.Anio = 2020;
            pickUp.Placa = "HDNCIE";
            pickUp.Tipo = "PickUp";
            pickUp.numpuertas = 4;
            pickUp.covertible = "no";
            pickUp.tipcaja= "si";



            pickUp.Encender();
            pickUp.Acelerar(68);
            pickUp.Bocina();
            pickUp.sistemadeseguridad();
            pickUp.Apagar();

            string pickUpInfo = $"Marca: {pickUp.Marca}\nModelo: {pickUp.Modelo}\nColor: {pickUp.Color}\nAño: {pickUp.Anio}\nPlaca: {pickUp.Placa}\nTipo: {pickUp.Tipo}\nNumeroDePuertas: {pickUp.numpuertas}\nConvertible: {pickUp.covertible}\nTipocaja: {pickUp.tipcaja}";
            pickUpLabel.Text = pickUpInfo; // Muestra la información

            pickUpInfoVisible = true;
        }

    }
    private void OnCounterClicked2(object sender, EventArgs e)
    {
        if (suvInfoVisible)
        {
            suvInfoVisible = false;
            suvLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            SUV suv = new SUV();
            suv.Marca = "Porsche";
            suv.Modelo = "Macan";
            suv.Color = "Rojo";
            suv.Anio = 2024;
            suv.Placa = "HDUWJL";
            suv.Tipo = "SUV";
            suv.lucesled = "si";
            suv.polarizado= "si";
            suv.parabrisas = "si";
            suv.Encender();
            suv.Acelerar(80);
            suv.Bocina();
            suv.balsas();
            suv.Apagar();

            string suvInfo = $"Marca: {suv.Marca}\nModelo: {suv.Modelo}\nColor: {suv.Color}\nAño: {suv.Anio}\nPlaca: {suv.Placa}\nTipo: {suv.Tipo}\nLucesLed: {suv.lucesled}\nPolarizado: {suv.polarizado}\nParabrisas: {suv.parabrisas}";
            suvLabel.Text = suvInfo; // Muestra la información

            suvInfoVisible = true;
        }
    }
    private void OnCounterClicked3(object sender, EventArgs e)
    {
        if (cuatroPorCuatroInfoVisible)
        {
            cuatroPorCuatroInfoVisible = false;
            cuatroPorCuatroLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            CuatroPorCuatro cuatroPorCuatro = new CuatroPorCuatro();
            cuatroPorCuatro.Marca = "Ford";
            cuatroPorCuatro.Modelo = "F250";
            cuatroPorCuatro.Color = "Negro";
            cuatroPorCuatro.Anio = 2010;
            cuatroPorCuatro.Placa = "BTSFFT";
            cuatroPorCuatro.Tipo = "4x4";
            cuatroPorCuatro.respiradero = "si";
            cuatroPorCuatro.defensa= "si";
            cuatroPorCuatro.llantaderepuesto = "si";
            



            cuatroPorCuatro.Encender();
            cuatroPorCuatro.Acelerar(100);
            cuatroPorCuatro.Bocina();
            cuatroPorCuatro.traccion();
            cuatroPorCuatro.Apagar();
            cuatroPorCuatro.traccion();


            string cuatroPorCuatroInfo = $"Marca: {cuatroPorCuatro.Marca}\nModelo: {cuatroPorCuatro.Modelo}\nColor: {cuatroPorCuatro.Color}\nAño: {cuatroPorCuatro.Anio}\nPlaca: {cuatroPorCuatro.Placa}\nTipo: {cuatroPorCuatro.Tipo}\nRespiradero: {cuatroPorCuatro.respiradero}\nDefensa: {cuatroPorCuatro.defensa}\nLlanta de Repuesto: {cuatroPorCuatro.llantaderepuesto}";
            cuatroPorCuatroLabel.Text = cuatroPorCuatroInfo; // Muestra la información

            cuatroPorCuatroInfoVisible = true;
        }
    }

}

