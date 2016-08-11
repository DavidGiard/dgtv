import { Component, Input, OnInit, ComponentResolver, ComponentRef, ViewChild, ViewContainerRef } from '@angular/core';
import { IEpisode } from './IEpisode';
import { Router } from '@angular/router';
import { EpisodeService } from './episode.service';


@Component({
  selector: 'episode',
  templateUrl: '/app/episode.html',
})
export class EpisodeComponent {

  @Input()
  episode: IEpisode;

  goToDetails(episode: IEpisode) {
    let link = ['/episodeDetails', episode.id];
    this.router.navigate(link);
    return false;
  }

getAllEpisodesForGuest(guest: string){
    let link = ['/episodeList/guest', guest];
    this.router.navigate(link);
    return false;
}


getAllEpisodesForLocation(location: string){
    let link = ['/episodeList/location', location];
    this.router.navigate(link);
    return false;
}


  // componentRef: ComponentRef;


  // constructor(private componentResolver:ComponentResolver) {}
  constructor(
    private episodeService: EpisodeService,
    private router: Router) {
  }


  ngAfterViewInit() {
    // this.componentResolver.resolveComponent(DescriptionComponent).then((factory) => {
    //   this.componentRef = this.target.createComponent(factory);
    // });
  }

  ngOnInit() {

  }

}

