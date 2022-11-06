import { GetUserInfoInput } from "../../modules/userInfo/GetUserInfoInput";
import api from "../../utils/request/api";

let name = 'simple'

class UserInfoApi {
    /**
     * 获取所有用户
     */
    GetListAsync(input: GetUserInfoInput | null) {
        return api.get(name + '/api/UserInfo/list', input)
    }

    /**
     * 获取当前用户详情
     * @returns 
     */
    GetAsync() {
        return api.get(name + '/api/UserInfo', null)
    }
}

export default new UserInfoApi()