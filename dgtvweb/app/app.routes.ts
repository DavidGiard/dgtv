import { provideRouter, RouterConfig }  from '@angular/router';
import { EpisodeListComponent } from './episodeList.component';
import { EpisodeComponent } from './episode.component';
import { EpisodeDetailComponent } from './episodeDetails.component';

import { TestComponent } from './test.component';

const routes: RouterConfig = [
  {
    path: '',
    redirectTo: '/episodeList',
    pathMatch: 'full'
  },
  {
    path: 'episodeList',
    component: EpisodeListComponent
  },
  {
    path: 'episode',
    component: EpisodeComponent
  },
  {
    path: 'episodeDetails/:id',
    component: EpisodeDetailComponent
  },
  {
    path: 'episodeList/guest/:guest',
    component: EpisodeListComponent
  },
  {
    path: 'episodeList/location/:location',
    component: EpisodeListComponent
  },
  {
    path: 'test',
    component: TestComponent
  },
];

export const appRouterProviders = [
  provideRouter(routes)
];