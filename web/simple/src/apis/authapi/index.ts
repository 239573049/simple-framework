import { SignOnInput } from "../../modules/auth/SignOnInput";
import api from "../../utils/request/api";

let name = 'auth/'

class AuthApi {
    /**
     * 登录认证
     * @param input 登录参数
     * @returns token
     */
    SignOn(input: SignOnInput) {
        return api.post(name + '/api/Auth/sign-on', input)
    }
}