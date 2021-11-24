import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { MatButtonModule } from "@angular/material/button";
import { MatCardModule } from "@angular/material/card";
import { MatGridListModule } from "@angular/material/grid-list";
import { MatIconModule } from "@angular/material/icon";
import { MatInputModule } from "@angular/material/input";
import { MatListModule } from "@angular/material/list";
import { MatSelectModule } from "@angular/material/select";
import { MatSidenavModule } from "@angular/material/sidenav";
import { MatTableModule } from "@angular/material/table";
import { MatToolbarModule } from "@angular/material/toolbar";
import { BrowserModule } from "@angular/platform-browser";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { AppRoutingModule } from "./app-routing.module";
import { MatBadgeModule } from "@angular/material/badge";
// Imports dos componentes internos
import { AppComponent } from "./app.component";
import { TemplateComponent } from "./components/template/template.component";
import { IndexComponent } from "./components/views/home/index/index.component";
import { CadastrarProdutoComponent } from "./components/views/produto/cadastrar-produto/cadastrar-produto.component";
import { ListarProdutoComponent } from "./components/views/produto/listar-produto/listar-produto.component";
import { CarrinhoComponent } from "./components/views/home/carrinho/carrinho.component";

@NgModule({
    declarations: [
        AppComponent,
        ListarProdutoComponent,
        CadastrarProdutoComponent,
        TemplateComponent,
        IndexComponent,
        CarrinhoComponent,
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        HttpClientModule,
        FormsModule,
        BrowserAnimationsModule,
        MatToolbarModule,
        MatIconModule,
        MatButtonModule,
        MatSidenavModule,
        MatListModule,
        MatTableModule,
        MatCardModule,
        MatSelectModule,
        MatInputModule,
        MatGridListModule,
        MatBadgeModule,
    ],
    providers: [],
    bootstrap: [AppComponent],
})
export class AppModule {}
