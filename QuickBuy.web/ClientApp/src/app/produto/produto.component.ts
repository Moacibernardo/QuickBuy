import { Component } from "@angular/core"

@Component({
  selector: "app-produto",
  template : "<html><body>{{ obterNome() }}</body></html>"
})
export class ProdutoComponent {// Nome dad classes começando com maísuculo por conta da convenção PascalCase
/* camelCase para variáveis. atributos e nomes das funções */

  public nome: string;
  public liberadoParavenda: boolean;

  public obterNome(): string {
    return "Samsung";

  }


}
