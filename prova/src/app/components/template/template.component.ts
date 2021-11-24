import {
  Component,
  OnInit,
  Output,
  EventEmitter,
} from "@angular/core";
import { ItemVenda } from "src/app/models/item-venda";

@Component({
  selector: "app-template",
  templateUrl: "./template.component.html",
  styleUrls: ["./template.component.css"],
})
export class TemplateComponent implements OnInit {
  itens: ItemVenda[] = [];
  @Output()
  totalItens = new EventEmitter<number>();
  constructor() {}

  ngOnInit(): void {}
}
