export interface PagedResultDto<T> {
    items: T[];
    totalCount: number;
}