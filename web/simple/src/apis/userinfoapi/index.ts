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
}

export default new UserInfoApi()