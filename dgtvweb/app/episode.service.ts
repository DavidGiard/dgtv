import { Injectable, OnInit } from '@angular/core';
import { episodesList } from './mock-episodes';
import {IEpisode} from './IEpisode';

import { Headers, Http, Response } from '@angular/http';
import { Observable }     from 'rxjs/Observable';
import { Observer }     from 'rxjs/Observer';
// import 'rxjs/add/operator/toPromise';

//import 'rxjs/add/observable';

// Statics
import 'rxjs/add/observable/throw';

// Operators
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/debounceTime';
import 'rxjs/add/operator/distinctUntilChanged';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/switchMap';
import 'rxjs/add/operator/toPromise';



@Injectable()
export class EpisodeService implements OnInit {

    private episodessUrl = 'http://localhost:57871/api/episode';  // URL to web api
    episodes: IEpisode[] = [];
    constructor(private http: Http) { }

    ngOnInit() {
    }

    getEpisodes_withPromise() {
        return Promise.resolve(episodesList);
        // .toPromise()
        // .then(response => response.json())
    }

    getEpisodes(): Observable<IEpisode[]> {
        console.log("SERVICE getEpisodes");

        return Observable.create((observer: Observer<any>) => {

            this.http.get(this.episodessUrl)
                .subscribe(
                response => {
                    this.episodes = response.json();
                    observer.next(this.episodes);
                })
        })
    }

    private extractData(res: Response) {
        let body = res.json();
        return body.data || {};
    }

    private handleError(error: any) {
        let errMsg = (error.message) ? error.message :
            error.status ? `${error.status} - ${error.statusText}` : 'Server error';
        console.error(errMsg); // log to console instead
        return Observable.throw(errMsg);
    }


    getEpisode(id: number) {
        return this.episodes.find(e => e.id == id);

        // return this.getEpisodes()
        //     .then(episodes => episodes.find(episode => episode.id === id));
    }


    getEpisodesForGuest(guest: string, allEpisodes: IEpisode[]) {

        return allEpisodes.filter(
            function (ep: IEpisode, index: number, array: IEpisode[]) {
                let found = false;
                for (var index = 0; index < ep.guests.length; index++) {
                    var thisGuest = ep.guests[index];
                    if (encodeURI(thisGuest).toUpperCase() === encodeURI(guest).toUpperCase()) {
                        found = true;
                    }
                }

                return found;
            }
        )

    }


    getEpisodesForLocation(location: string, allEpisodes: IEpisode[]) {
        location = encodeURI(location.toUpperCase());
        return allEpisodes.filter(episode => (encodeURI(episode.location).toUpperCase()) === location);

    }

}
