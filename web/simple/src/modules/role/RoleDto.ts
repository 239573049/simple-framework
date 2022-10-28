export interface RoleDto {
    name: string | null;
    code: string | null;
    index: number;
    isPrivate: boolean;
    tenantId: string | null;
}