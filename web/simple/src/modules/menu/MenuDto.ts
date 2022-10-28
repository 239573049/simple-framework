export interface MenuDto {
    id: string;
    title: string | null;
    icon: string | null;
    index: number;
    component: string | null;
    path: string | null;
    parentId: string | null;
    tenantId: string | null;
}