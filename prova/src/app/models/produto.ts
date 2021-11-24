import { Categoria } from "./categoria";

export interface Produto {
    id?: number;
    nome: string;
    descricao: string;
    preco: number;
    quantidade: number;
    categoriaId: number;
    categoria?: Categoria;
    criadoem?: string;
}
