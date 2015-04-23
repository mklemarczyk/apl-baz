<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Klient */

$this->title = 'Create Klient';
$this->params['breadcrumbs'][] = ['label' => 'Klients', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="klient-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
