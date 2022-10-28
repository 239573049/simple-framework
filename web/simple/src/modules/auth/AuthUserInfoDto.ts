import { RoleDto } from "../role/RoleDto";
import { UserInfoStatus } from "../userInfo/UserInfoStatus";

export interface AuthUserInfoDto {
    id: string;
    name: string;
    userName: string;
    passWord: string;
    avatar: string;
    status: UserInfoStatus;
    tenantId: string | null;
    roles: RoleDto[];
}