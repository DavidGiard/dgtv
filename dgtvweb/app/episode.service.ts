import { Injectable, OnInit } from '@angular/core';
import { episodesList } from './mock-episodes';
import {IEpisode} from './IEpisode';

import { Headers, Http } from '@angular/http';
// import 'rxjs/add/operator/toPromise';


@Injectable()
export class EpisodeService implements OnInit {

    private episodessUrl = 'http://localhost:57871/api/episode';  // URL to web api
    episodes: IEpisode[] = [];
    constructor(private http: Http) { }

  ngOnInit() {
    //   console.log("Service OnInit");
    //   this.getEpisodes();
  }

    xgetEpisodes() {
        return Promise.resolve(episodesList);
    }

    getEpisodes() {
        console.log("SERVICE getEpisodes");

        debugger;
        return this.http.get(this.episodessUrl)
            .subscribe(response => this.episodes = response.json())
            // .toPromise()
        // .then(response => response.json())
    }

    getEpisode(id: number) {
        return this.episodes.find(e => e.id == id);
        // return this.episodes.find(e => e.id == id);

        // return this.getEpisodes()
        //     .then(episodes => episodes.find(episode => episode.id === id));
    }


    getEpisodesForGuest(guest: string) {

        return this.episodes.filter(
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

        // .then(episodes => episodes.filter(
        //     function (ep: IEpisode, index: number, array: IEpisode[]) {
        //         let found = false;
        //         for (var index = 0; index < ep.guests.length; index++) {
        //             var thisGuest = ep.guests[index];
        //             // thisGuest = thisGuest;
        //             if (encodeURI(thisGuest).toUpperCase() === encodeURI(guest).toUpperCase()) {
        //                 found = true;
        //             }
        //         }

        //         return found;
        //     }
        // ))
    }


    getEpisodesForLocation(location: string) {
        // location = encodeURI(location.toUpperCase())
        // return this.getEpisodes()
        //     .then(episodes => episodes.filter(

        //         function (ep: IEpisode, index: number, array: IEpisode[]) {
        //             var thisLocation = ep.location;
        //             if (encodeURI(thisLocation).toUpperCase() === location) {
        //                 return true;
        //             }
        //             else {
        //                 return false;
        //             }

        //         }
        //     ))



        // return this.getEpisodes()
        //     .then(episodes => episodes.filter(episode => (encodeURI(episode.location).toUpperCase()) === location));

        // return this.getEpisodes()
        //     .then(episodes => episodes.filter(
        //         function (ep: IEpisode, index: number, array: IEpisode[]) {
        //             let found = false;
        //             for (var index = 0; index < ep.locations.length; index++) {
        //                 var thislocation = ep.locations[index];
        //                 thislocation = thislocation;
        //                 if (encodeURI(thislocation).toUpperCase() == encodeURI(location).toUpperCase()){
        //                     found = true;
        //                 }
        //             }

        //             return found;
        //         }
        //     ))
    }

}
