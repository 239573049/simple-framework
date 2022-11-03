import { PagedRequestDto } from "./PagedRequestDto";

export interface SimpleInput extends PagedRequestDto {
    keywords: string | undefined;
    startTime: string | null;
    endTime: string | null;
}