export interface Tweet {
    name?: string;
    handle: string;
    text: string;
    createdOn: Date;
}

export interface Profile {
    handle: string;
    name: string;
    bio: string;
}

export interface TrendingTag {
    tag: string;
    count: number;
}