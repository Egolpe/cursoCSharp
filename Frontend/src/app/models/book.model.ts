export interface Book {
    id: number;
    title: string;
    author?: any;
    price?: number;
    description?: string;
    isbn?: string;
    releaseYear?: number;
    authorId?: number;
    categories?: any[];

}