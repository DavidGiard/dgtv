import { Component, OnInit, OnDestroy, DynamicComponentLoader, ElementRef, Injector } from '@angular/core';
import { IEpisode } from './IEpisode';
import { EpisodeService } from './episode.service';
import { EmbeddedVideoComponent } from './embedded-video.component';
import { EpisodeComponent } from './episode.component';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'episode-list',
  templateUrl: '/app/episodelist.html',
  directives: [EpisodeComponent]
})
export class EpisodeListComponent implements OnInit, OnDestroy {
  episodes: IEpisode[];
  allEpisodes: IEpisode[];
  sub: any;
  errorMessage: string;
  mode = 'Observable';

  constructor(
    private episodeService: EpisodeService,
    private route: ActivatedRoute) {
    console.log("CONSTRUCTOR");

  }


  getEpisodes() {

    this.episodeService.getEpisodes()
      .subscribe(
      episodes => this.episodes = episodes,
      error => this.errorMessage = <any>error);

    // this.episodeService.getEpisodes().then(episodes => this.episodes = episodes);
  }

  getEpisodesForGuest(guest: string) {

    return this.episodeService.getEpisodesForGuest(guest, this.allEpisodes)

    // this.episodeService.getEpisodesForGuest(guest)
    //   .then(episodes => this.episodes = episodes);
  }

  getEpisodesForLocation(location: string) {
    return this.episodeService.getEpisodesForLocation(location, this.allEpisodes);
    // this.episodeService.getEpisodesForLocation(location)
    //   .then(episodes => this.episodes = episodes);
  }

  ngOnInit() {
    console.log("NGONINIT");

    this.sub = this.route.params.subscribe(params => {
      let guest = params['guest'];
      let location = params['location'];

      this.episodeService.getEpisodes().subscribe((data) => {
        this.episodes = data;
        this.allEpisodes = data;

        if (guest) {
          this.episodes = this.getEpisodesForGuest(guest);
        }
        else if (location) {
          this.episodes = this.getEpisodesForLocation(location);
        }
        else
        {
          this.episodes = this.allEpisodes;
        }
      });

    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

}
