export interface CreateRoleDto {
    name: string | null;
    code: string | null;
    index: number;
    isPrivate: boolean;
}