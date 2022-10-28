export interface MenuTreeDto {
    itemKey: string;
    text: string | null;
    icon: string | null;
    index: number;
    component: string | null;
    link: string | null;
    parentId: string | null;
    tenantId: string | null;
    items: MenuTreeDto[];
}