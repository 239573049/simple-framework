import { DictionarySettingType } from "../views/DictionarySettingType";

export interface DictionarySettingDto {
    id: string;
    key: string;
    value: { [key: string]: any; };
    type: DictionarySettingType;
}