import { SaveAsyncDictionarySettingDto } from "../../modules/dictionarysetting/SaveAsyncDictionarySettingDto";
import { SimpleInput } from "../../modules/shareds/SimpleInput";
import api from "../../utils/request/api";

let name = 'simple'

class DictionarySettingApi {

    /**
     * 获取字典详情
     * @param id 
     * @returns 
     */
    GetAsync(id: string) {
        return api.get(name + "/api/DictionarySetting/" + id, null)
    }

    /**
     * 获取字典详情
     * @param key 
     * @returns 
     */
    GetKeyAsync(key: string) {
        return api.get(name + "/api/DictionarySetting/" + key, null)
    }

    /**
     * 添加或编辑字典
     * @param dto 
     */
    SaveAsync(dto: SaveAsyncDictionarySettingDto) {
        return api.post(name + "/api/DictionarySetting", dto)
    }

    /**
     * 获取字典列表
     * @param input 
     */
    GetListAsync(input: SimpleInput) {
        return api.get(name + "/api/DictionarySetting/list", input)
    }
}

export default new DictionarySettingApi()