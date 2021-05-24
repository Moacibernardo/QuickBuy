import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls:["./login.component.css"]

})
export class LoginComponent {

  public usuario = new Usuario();

  constructor() {
    this.usuario = new Usuario();
  }

  entrar() {
    alert(this.usuario.email + " - " + this.usuario.senha);

  }

}
