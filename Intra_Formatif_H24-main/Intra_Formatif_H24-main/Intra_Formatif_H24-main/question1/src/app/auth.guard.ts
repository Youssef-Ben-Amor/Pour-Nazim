import { inject } from '@angular/core';
import { CanActivateFn } from '@angular/router';
import { Router } from '@angular/router';
import { User } from './user';
import { UserService } from './user.service';

export const authGuard: CanActivateFn = (route, state) => {
  const router = inject(Router);
  const service  = inject(UserService);

  if(service.currentUser){
    console.log(service.currentUser);    
    return true;
  } else {
    router.navigate(['/login']);
    return false;
  }

}
