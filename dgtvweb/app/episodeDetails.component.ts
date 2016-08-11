import { Component, OnInit, OnDestroy } from '@angular/core';
import { IEpisode } from './IEpisode';
import { ActivatedRoute } from '@angular/router';
import { EpisodeService } from './episode.service';

@Component({
  //selector: 'episodeDetail',
  templateUrl: '/app/episodeDetails.html',
})
export class EpisodeDetailComponent implements OnInit, OnDestroy {

  constructor(
    private episodeService: EpisodeService,
    private route: ActivatedRoute) {
  }

  private episodeDtl: IEpisode;
  sub: any;

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      let id = +params['id'];
      this.episodeDtl = this.episodeService.getEpisode(id);

      // let id = +params['id'];
      // this.episodeService.getEpisode(id)
      //   .then(episode => this.episodeDtl = episode);
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  goBack() {
    window.history.back();
  }


}

