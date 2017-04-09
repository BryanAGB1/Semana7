<%@ Page Title="Semana 7" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Semana7._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="estilo.css" rel="stylesheet" />
    
    <div class="jumbotron">


            <h1 align="center">Calculadora</h1>

            <div align="center" class="row">
                <strong>

                    <input id="valores" name="valores" runat="server" type="text" onkeypress="return solonumeros(event)" />

                </strong>
                <br>
                <button id="Ans" type="button" class="btn btn-default">Ans</button>
                <button id="C" type="button" class="btn btn-default" value="C" onclick="eliminar()" onserverclick="C">C</button>
                <button id="Borrar" type="button" class="btn btn-default" value="Borrar" onclick="eliminar_todo()">Borrar</button>
                <button id="Dividir" type="button" class="btn btn-warning" value="/" onclick="comprobar(value)">/</button>
                <br>
                <button id="Num7" type="button" class="btn btn-primary" value="7" onClick="retornar(value)">7</button>
                <button id="Num8" type="button" class="btn btn-primary" value="8" onClick="retornar(value)">8</button>
                <button id="Num9" type="button" class="btn btn-primary" value="9" onClick="retornar(value)">9</button>
                <button id="Multiplicar" type="button" class="btn btn-warning" value="*" onclick="comprobar(value)">*</button>
                <br>
                <button id="Num4" type="button" class="btn btn-primary" value="4" onClick="retornar(value)">4</button>
                <button id="Num5" type="button" class="btn btn-primary" value="5" onClick="retornar(value)">5</button>
                <button id="Num6" type="button" class="btn btn-primary" value="6" onClick="retornar(value)">6</button>
                <button id="Restar" type="button" class="btn btn-warning" value="-" onclick="comprobar(value)">-</button>
                <br>
                <button id="Num1" type="button" class="btn btn-primary" value="1" onClick="retornar(value)">1</button>
                <button id="Num2" type="button" class="btn btn-primary" value="2" onClick="retornar(value)">2</button>
                <button id="Num3" type="button" class="btn btn-primary" value="3" onClick="retornar(value)">3</button>
                <button id="Sumar" type="button" class="btn btn-warning" value="+" onclick="comprobar(value)">+</button>
                <br>
                <button id="SuRe" type="button" class="btn btn-success" value="S/R" onclick="raizc(value)">S/R</button>
                <button id="Num0" type="button" class="btn btn-primary" value="0" onClick="retornar(value)">0</button>
                <button id="Punto" type="button" class="btn btn-success"value="." onclick="comprobar(value)">.</button>
                <button Id="Resultado" type="button" class="btn btn-danger"value="=" onClick="calcular(value)">=</button>
                
            </div>
        </div>

</asp:Content>