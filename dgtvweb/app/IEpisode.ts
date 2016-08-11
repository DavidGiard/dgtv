import { ILink } from './ILink';

export interface IEpisode {
    id: number;
    
    title: string;
    description: string;
    dateRecorded: string;
    dateReleased?: string;
    location: string;
    videoUrl: string;
    videoPlayer: string;
    lowResVideo?: string;
    highResVideo?: string;
    guests: string[],
    episodeNumber: number;
    links?: ILink[],
    

}