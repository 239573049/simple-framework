import { DictionarySettingType } from "../views/DictionarySettingType";

export interface SaveAsyncDictionarySettingDto {
    id: string;
    key: string;
    value: { [key: string]: any; };
    type: DictionarySettingType;
}