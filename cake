cd /var/lib/jenkins/jobs/projectname/workspace/app
cp /var/www/projectname/app/Config/database.php Config/
mkdir -p tmp && chmod -R 777 tmp && rm -R tmp/*
cp /var/www/projectname/app/composer.phar ./ && php composer.phar update
Console/cake test app AllApp --stderr
