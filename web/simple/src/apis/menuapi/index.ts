import { MenuDto } from './../../modules/menu/MenuDto';
import { CreateMenuDto } from "../../modules/menu/CreateMenuDto";
import { GetMenuInput } from "../../modules/menu/GetMenuInput";
import api from "../../utils/request/api";

let name = 'auth'

class MenuApi {
    /**
     * 创建菜单
     */
    Create(dto: CreateMenuDto) {
        return api.post(name + '/api/Menu', dto)
    }

    /**
     * 删除菜单
     */
    Delete(id: string) {
        return api.del(name + "/api/Menu", id)
    }

    /**
     * 获取菜单树形数据结构
     * @param input 
     * @returns 
     */
    GetMenuTree(input: GetMenuInput) {
        return api.get(name + "/api/Menu/menu-tree", input)
    }

    /**
     * 编辑菜单
     * @param dto 
     * @returns 
     */
    Update(dto: MenuDto) {
        return api.put(name + "/api/Menu", dto)
    }
}

export default new MenuApi()