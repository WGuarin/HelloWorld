using System.Collections;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
public class Vehicle{
    private int llantas;

    public Vehicle(int llantas){
        this.llantas = llantas;
    }
    public int getLlantas(){
        return this.llantas;
    }
    public void setLlantas(int llantas){
        this.llantas = llantas;
    }
}
public class Car<TPaint, TPlaca> : Vehicle{
    private TPaint paintColor;
    private TPlaca placa;
    private int cambio;

    public Car(int llantas, TPaint color, TPlaca placa) : base(llantas){
        this.paintColor = color;
        this.placa = placa;
        this.cambio = 0;
    }

    public String subirCambio(){
        cambio++;
        return "Cambio carro: " + cambio;
    }
    public String bajarCambio(){
        cambio--;
        return "Cambio carro: " + cambio;
    }


    public TPaint getPaintColor(){
        return this.paintColor;;
    }
    public void setPaintColor(TPaint paintColor){
        this.paintColor = paintColor;
    }
    public TPlaca getPlaca(){
        return this.placa;
    }
    public void setPlaca(TPlaca placa){
        this.placa = placa;
    }

    public bool Equals(Car<TPlaca, TPaint> a){
        return string.Equals(a.getPlaca(), this.getPlaca());
    }

}
public sealed class Moto : Vehicle{
    private int patas, cambio;

    public Moto(int llantas, int patas) : base(llantas){
        this.patas = patas;
        this.cambio = 0;
    }

    public String subirCambio(){
        cambio++;
        return "Cambio moto: " + cambio;
    }
    public String bajarCambio(){
        cambio--;
        
        return "Cambio moto: " + cambio;
    }
}
public class Program{
    static void Main(String[] args){
    
        var a = 0;


    }
}