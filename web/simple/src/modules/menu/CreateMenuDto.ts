export interface CreateMenuDto {
    title: string | null;
    icon: string | null;
    index: number;
    component: string | null;
    path: string | null;
    parentId: string | null;
}