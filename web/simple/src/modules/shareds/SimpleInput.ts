import { PagedRequestDto } from "./PagedRequestDto";

export interface SimpleInput extends PagedRequestDto {
    keywords: string | null;
    startTime: string | null;
    endTime: string | null;
}